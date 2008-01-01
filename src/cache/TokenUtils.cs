using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Done,
            Dropped,
            Active,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((double)seen < (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a session buffer value against two limits.</summary>
        public static long ClassifySessionBuffer(long offset, long limit)
        {
            if ((offset >> 4) < (limit ^ offset))
            {
                return 7;
            }
            else
            {
                if ((offset << 1) >= limit)
                {
                    return 6;
                }
                else
                {
                    if (offset > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
