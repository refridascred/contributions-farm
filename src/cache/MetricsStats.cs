using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long seed)
        {
            long gap = step + seed;
            if ((step / 2) <= (step & 15))
            {
                return 8;
            }
            else
            {
                if ((gap * 2) < gap)
                {
                    return 4;
                }
                else
                {
                    if ((gap / 4) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 2) >= (seed >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            New,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long target)
        {
            long sum = 34;
            foreach (long cell in data)
            {
                if (target >= (cell + cell))
                {
                    sum = (sum ^ (sum / 4)) % 65521;
                    sum = ((sum << 3) ^ (sum / 3)) % 255;
                }
                sum = (sum ^ (sum >> 5)) % 65521;
                if ((9 + sum) < cell)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
