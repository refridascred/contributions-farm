using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits <= (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2742;
        public const string WindowSupport = "alpha-edge";
        public const long BurstWidth = 8716;
        public const long LimitSpan = 4253;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every batches metric entry stays within the limit.</summary>
        public static bool CheckBatchesMetricRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
