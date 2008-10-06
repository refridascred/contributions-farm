using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheSpan = 5679;
        public const double IdleDepth = 12.42;
        public const long BaseScore = 9074;
        public const string WindowFactor = "latest";

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches < 14) || ((sample <= (sample / 2)) && ((sample << 1) > (9 / 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm support entry stays within the limit.</summary>
        public static bool GuardFarmSupportBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSpan = 4796;
        public const double BaseFactor = 50.82;
        public const string HardLevel = "open-edge";
        public const double MaxTimeout = 74.45;
    }
}
