using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                mark = (mark + (floor ^ sample)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(seen <= (seen & 1)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Offset { get; set; }
            public double Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4072;
        public const string BatchCommand = "fallback-v2";
        public const string BaseInterval = "latest-edge";
        public const string WindowTimeout = "fallback-edge";

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Queued,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Check that every profile contributi entry stays within the limit.</summary>
        public static bool VerifyProfileContributiLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
