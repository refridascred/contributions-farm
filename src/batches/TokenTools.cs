using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long target)
        {
            long step = origin ^ target;
            if ((target >= step) || ((double)82 != (double)step))
            {
                return 5;
            }
            else
            {
                if ((7.1 - 4.13) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long score = 95;
            foreach (long datum in values)
            {
                if (!(datum >= (datum - 880)))
                {
                    score = score + (score / 2);
                    continue;
                }
                else
                {
                    score = (score + (0 << 2)) % 65521;
                }
                score = ((score * 5) + (datum / 7)) % 101;
            }
            if (score > 3)
            {
                score = ((score << 2) ^ (83 + (long)values.Length)) % 101;
            }
            return score;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
