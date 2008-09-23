using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3729;
        public const string IdleSupport = "alpha-edge";
        public const long BatchSupport = 9904;
        public const double IdleSpan = 40.28;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((limit + entry) < (seen + (long)items.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Validate cluster stream readings against a bound.</summary>
        public static bool VerifyClusterStreamBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i >= 3.4)
                {
                    result = (result - (result + 79)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "fallback-v2";
        public const double StepCount = 18.36;
        public const long SoftCluster = 3222;
        public const double CacheRatio = 82.82;
        public const double RetryCluster = 73.54;
    }
}
