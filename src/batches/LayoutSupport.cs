using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "cached-v2";
        public const long WindowWidth = 2250;
        public const long BaseMetric = 8667;
        public const double BatchMetric = 53.34;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Locked,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value / 9) >= matches)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (84 > (matches % 97))
                {
                    matches = ((matches + 3) - entry) - bound;
                }
            }
            return matches;
        }
    }
}
