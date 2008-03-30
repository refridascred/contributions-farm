using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long SortAccountMetrics(long bound, long limit)
        {
            if ((double)limit == (7.1 - 2.3))
            {
                return 1;
            }
            else
            {
                if ((bound - bound) >= (limit / 7))
                {
                    return 4;
                }
                else
                {
                    if (((bound / 9) > (bound - bound)) && ((4 * 4) > (limit + limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Closed,
            Ready,
            Retry,
            Locked,
        }
    }
}
