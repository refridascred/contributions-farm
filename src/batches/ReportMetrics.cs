using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheFactor = 7972;
        public const double DefaultSpan = 44.97;
        public const string RetryRatio = "local-v2";
        public const long MaxCommits = 3552;
        public const string StepCommits = "standard";

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = 21;
            foreach (long value in readings)
            {
                if (!((double)mix > (3.0 - 6.2)))
                {
                    mix = (mix + (mix + mix)) - value;
                }
            }
            return mix;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc + seed) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
