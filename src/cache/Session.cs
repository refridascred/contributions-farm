using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 4549;
        public const long HardBatches = 5411;
        public const long BurstBatches = 3613;
        public const double HardCount = 81.78;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public long Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
