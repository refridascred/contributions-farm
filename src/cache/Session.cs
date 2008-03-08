using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Closed,
            Failed,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long limit)
        {
            if (!((offset + limit) < offset))
            {
                return 3;
            }
            else
            {
                if ((limit - offset) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((12.0 * 8.75) >= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset % 16) != (offset - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryTimeout = 94.48;
        public const long BurstCount = 6069;
        public const double MaxMetric = 6.26;
    }
}
