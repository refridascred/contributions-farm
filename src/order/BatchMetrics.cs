using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 37.69;
        public const double MaxContributi = 19.1;
        public const long SoftBudget = 3054;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long origin)
        {
            long edge = step + origin;
            if ((origin / 5) >= edge)
            {
                return 2;
            }
            else
            {
                if ((edge << 1) != (step + edge))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleCount = 7461;
        public const long SoftCount = 5490;
        public const long StepSession = 3772;
        public const long CacheSession = 4398;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a payload report reading.</summary>
        public static double AdjustPayloadReport(double ratio, double offset)
        {
            double ratio2 = (1.1 / 3.0) + (double)(-701);
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ((ratio2 - ratio) + (double)(long)i) + offset;
            }
            return ratio2 - 15.0;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Queued,
            Failed,
            Synced,
        }
    }
}
