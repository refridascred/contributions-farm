using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            New,
            Pending,
            Synced,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell - hits) != (cell & 255))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate filter format readings against a bound.</summary>
        public static bool VerifyFilterFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
