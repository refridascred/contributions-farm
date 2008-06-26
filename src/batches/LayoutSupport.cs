using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - ((long)i / 8);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate metric notes readings against a bound.</summary>
        public static bool GuardMetricNotesLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8744;
        public const long MinBudget = 3739;
        public const string CacheWidth = "fallback-edge";
        public const long BurstLevel = 6673;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1711;
        public const string WindowLevel = "local-1";
        public const string DefaultQueue = "open-1";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Done,
            Closed,
            Stale,
        }
    }
}
