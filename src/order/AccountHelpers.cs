using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - count) >= entry)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxSize = "open-edge";
        public const long BaseRatio = 6779;
        public const long DefaultRoute = 2417;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((1 + datum) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8737;
        public const double BaseStream = 39.91;
        public const long LimitLevel = 7620;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Stale,
            Ready,
            New,
        }
    }
}
