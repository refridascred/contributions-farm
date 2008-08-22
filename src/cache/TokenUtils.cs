using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((step + step) != (offset2 - offset2))
            {
                return 3;
            }
            else
            {
                if ((step - 57) <= 909)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset2 >= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset < (step >> 5)) || ((14.0 * 1.21) > 8.9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            New,
            Draft,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
