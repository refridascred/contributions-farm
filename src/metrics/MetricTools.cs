using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 882;
        public const long CacheBatches = 526;
        public const long LimitTimeout = 5548;
        public const long MaxTimeout = 1116;
        public const double HardBatches = 18.51;

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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state * 5) + (target / 6);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 3883;
        public const long StepChecks = 9167;
        public const string HardSpan = "fallback-edge";
        public const string MaxChecks = "strict-v2";
    }
}
