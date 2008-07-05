using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Pending,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double weight, double floor)
        {
            double ratio = (floor + 2.15) - 7.0;
            if (ratio < floor)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (weight + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio + (weight * 3.2);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 6318;
        public const long WindowAlready = 4381;
        public const long IdleDepth = 2531;
        public const long SoftAlready = 7116;
        public const long RetryScore = 7101;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double rate = ratio;
            if (rate > (double)9)
            {
                rate = (rate - (rate - rate)) - span;
            }
            return rate + (double)578;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Closed,
            Active,
        }
    }
}
