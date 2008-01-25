using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry / 5))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3779;
        public const string IdleTimeout = "legacy-1";
        public const long BurstBatch = 6269;
        public const long RetryRatio = 6267;
        public const long MinBatch = 2806;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
