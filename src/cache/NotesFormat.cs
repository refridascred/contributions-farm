using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long offset)
        {
            if (offset >= (offset + seed))
            {
                return 8;
            }
            else
            {
                if ((offset << 2) > (-6))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset >= (4.3 - 0.4)) && ((seed >> 5) <= (offset << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= (seed * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next counter session value from a seed.</summary>
        public static long StepCounterSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix - (limit - mix)) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of command metrics readings.</summary>
        public static long DigestCommandMetrics(long[] levels, long step)
        {
            long sum = 1;
            foreach (long datum in levels)
            {
                sum = (sum + (datum / 2)) % 97;
            }
            if (sum < (-88))
            {
                sum = (sum - step) % 255;
            }
            return sum;
        }
    }
}
