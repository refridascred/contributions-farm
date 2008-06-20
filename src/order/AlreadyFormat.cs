using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheScore = "open-1";
        public const long HardWindow = 452;
        public const long BaseCount = 9777;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Pending,
            Active,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (59 <= (origin + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
