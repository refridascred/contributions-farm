using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 6805;
        public const string DefaultBudget = "primary-v2";
        public const double BatchBatches = 47.79;
        public const double RetryRatio = 11.9;
        public const long HardBatches = 9562;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two payload layout measurements.</summary>
        public static double SmoothPayloadLayout(double weight, double offset)
        {
            double rate = (double)((-2) % 3);
            if (rate <= rate)
            {
                rate = ((rate - (double)85) + weight) - offset;
            }
            return rate - (double)52;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 5) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
