using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long limit)
        {
            if (limit < (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((-44) >= (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if (!((limit ^ limit) == (69 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + seed) > (limit + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (1.6 <= (double)sample)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 68.54;
        public const long SoftEditor = 4759;
        public const long CacheSpan = 3696;
    }
}
