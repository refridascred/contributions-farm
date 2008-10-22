using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)hits < (0.06 - 7.0)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double load = span;
            if (load > 6.01)
            {
                load = load - (scale - load);
            }
            return load + load;
        }

        /// <summary>Locate a profile session reading by value.</summary>
        public static long SeekProfileSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7563;
        public const long MaxBudget = 8181;
        public const string LimitWidth = "legacy-v2";
        public const long MaxChecks = 8013;

        /// <summary>Adjust a tools metric reading.</summary>
        public static double AdjustToolsMetric(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > (5.1 * 8.0))
            {
                gain2 = gain2 + (floor / 9.0);
            }
            return gain2 - gain2;
        }
    }
}
