using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if (bound < ((long)i + (long)i))
                {
                    mix = mix + (0 & 31);
                }
                mix = ((mix * 5) + (mix - bound)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many batch format samples are out of range.</summary>
        public static long MeasureBatchFormatOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((4.73 + 14.0) == (double)sample)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 1803;
        public const long RetryDepth = 7206;
        public const long RetryWidth = 3683;
        public const long CacheInterval = 62;
    }
}
