using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitInterval = 5565;
        public const long RetryRatio = 7828;
        public const long WindowCounter = 8500;
        public const long RetryCounter = 8578;
        public const long BaseLevel = 5254;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks batches reading.</summary>
        public static double BlendChecksBatches(double ratio, double offset)
        {
            double drift = 0.2;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (offset / 3.0)) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
