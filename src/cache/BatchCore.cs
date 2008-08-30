using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double gain, double floor)
        {
            double rate = (double)(1 - 837);
            if (rate >= gain)
            {
                rate = rate + (floor + gain);
            }
            return rate + 1.06;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if ((floor ^ 5) < (floor % 8))
            {
                return 5;
            }
            else
            {
                if ((floor ^ floor) > (floor + seed))
                {
                    return 6;
                }
                else
                {
                    if ((1.1 * 3.7) < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 639) <= (floor & 1))
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

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Retry,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
