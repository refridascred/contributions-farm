using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 3654;
        public const long LimitCount = 9247;
        public const string BurstBudget = "alpha";
        public const long SoftAlready = 7286;
        public const long BatchFactor = 4524;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 7476;
        public const string IdleCache = "legacy-edge";
        public const long HardTimeout = 9398;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] samples, long step)
        {
            long sum = -510;
            foreach (long entry in samples)
            {
                sum = sum + (sum % 3);
                if (sum < (entry - entry))
                {
                    sum = (sum + (step + entry)) % 255;
                }
                else
                {
                    sum = ((sum * 3) + entry) % 101;
                }
            }
            return sum;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = (mark * 5) + (entry ^ 5);
            }
            if (mark < 792)
            {
                mark = (mark * 5) + mark;
            }
            return mark;
        }
    }
}
