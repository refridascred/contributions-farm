using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7308;
        public const double BurstTimeout = 54.14;
        public const long SoftQueue = 7838;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Find the first batches cache entry that matches the target.</summary>
        public static long LookupBatchesCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report already readings against a bound.</summary>
        public static bool GuardReportAlreadyRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
