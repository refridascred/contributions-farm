using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of tools layout readings.</summary>
        public static long OverlapToolsLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long target)
        {
            if ((offset ^ target) >= (target >> 2))
            {
                return 0;
            }
            else
            {
                if ((target - target) != (target % 8))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= (2.6 * 6.9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
