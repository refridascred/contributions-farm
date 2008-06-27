using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitFactor = 5779;
        public const double DefaultCount = 33.53;
        public const double MinCommand = 98.46;
        public const long BurstCommand = 7685;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)bound != (double)18)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Pending,
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 3883;
        public const long StepChecks = 9167;
        public const string HardSpan = "fallback-edge";
        public const string MaxChecks = "strict-v2";
    }
}
