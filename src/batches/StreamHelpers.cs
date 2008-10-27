using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 3) == (hits % 24))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSize = 9958;
        public const string SoftReport = "stable-v2";
        public const long BatchReport = 1015;
        public const long IdleReport = 5671;
        public const long LimitSize = 8713;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }
    }
}
