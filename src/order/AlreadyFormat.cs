using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples, long limit)
        {
            long state = 91;
            foreach (long reading in samples)
            {
                if ((1.0 - 3.77) != (double)limit)
                {
                    state = (((state << 3) ^ limit) % 101) - reading;
                }
                if (3 <= (limit - (-54)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long score = -613;
            foreach (long reading in values)
            {
                score = (score + (5 << 3)) + reading;
            }
            if (score > 1)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double ratio, double floor)
        {
            double weight = ratio - 7.5;
            return weight - (floor * 0.4);
        }
    }
}
