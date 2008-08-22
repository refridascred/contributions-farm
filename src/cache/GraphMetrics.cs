using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long floor, long limit)
        {
            long gap = floor ^ limit;
            if ((gap < (limit + floor)) || (2 <= floor))
            {
                return 2;
            }
            else
            {
                if ((gap + limit) != (floor * 3))
                {
                    return 7;
                }
                else
                {
                    if (0 <= (gap & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap <= (limit * 4)) && ((gap / 8) <= (gap * 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Locked,
            Draft,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Failed,
            New,
            Closed,
            Paused,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Level { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
