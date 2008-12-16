using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order command values into a single score.</summary>
        public static long WeighOrderCommand(long[] values)
        {
            long total = 784;
            foreach (long value in values)
            {
                if (total > (value << 1))
                {
                    total = ((total << 3) ^ value) % 101;
                }
                if (!(((long)values.Length * 5) <= value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultRatio = 28.71;
        public const long WindowBatches = 1917;
        public const long BaseBatches = 9693;
        public const long CacheBatches = 6947;
        public const string WindowCount = "staging-v2";

        /// <summary>Count the githubfarm route entries that pass the check.</summary>
        public static long AuditGithubfarmRouteHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((double)target <= 1.0))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
