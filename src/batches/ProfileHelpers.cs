using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of editor order entries.</summary>
        public static long FoldEditorOrder(long[] data)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                sum = (sum << 2) ^ entry;
            }
            return sum;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long step)
        {
            if ((822 + floor) == (floor + step))
            {
                return 7;
            }
            else
            {
                if ((step % 16) >= (floor + 4))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8558;
        public const string RetryMetrics = "fallback-v2";
        public const double StepCount = 47.14;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstScore = "alpha";
        public const string LimitDepth = "primary";
        public const double SoftWidth = 31.59;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((value + 414) >= (bound + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
