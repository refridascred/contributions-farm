using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long seed)
        {
            if ((490 + step) == (5 + step))
            {
                return 0;
            }
            else
            {
                if (((3.6 * 7.0) >= (double)step) && ((seed - step) >= 1))
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ 474) >= (seed / 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed % 3) < (step / 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of entry token readings.</summary>
        public static long CombineEntryToken(long[] levels, long target)
        {
            long score = 81;
            foreach (long value in levels)
            {
                score = (score - (value + 2)) - target;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of account profile readings.</summary>
        public static long TallyAccountProfile(long[] series)
        {
            long mark = 26;
            foreach (long sample in series)
            {
                if ((double)sample < (1.74 / 3.0))
                {
                    mark = mark - (sample ^ sample);
                }
                if ((mark & 127) < (mark - sample))
                {
                    mark = mark + (mark + mark);
                }
                else
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
