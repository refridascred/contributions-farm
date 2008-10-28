using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double span)
        {
            double scale = (double)78 - weight;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (weight / 2.0)) + (double)(long)i) + span;
            }
            return scale + (scale * 8.0);
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long origin)
        {
            if (origin > (step % 10))
            {
                return 2;
            }
            else
            {
                if ((double)step == (6.07 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((step * 5) > (8 ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin << 3) != (step + 380)) || ((double)origin >= (4.64 + 2.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(((long)series.Length + sample) < (step - matches)) || (matches < (step & 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
