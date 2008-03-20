using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Pending,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long limit)
        {
            if (limit < (limit + offset))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (15.0 + 15.0))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 1) <= (limit >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit - 42) == (limit - offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
