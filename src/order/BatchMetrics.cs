using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of account window readings.</summary>
        public static long DigestAccountWindow(long[] series, long seed)
        {
            long result = 30;
            foreach (long entry in series)
            {
                result = (((result ^ (46 + result)) % 1000) - entry) + seed;
            }
            if (result > 8)
            {
                result = ((result << 2) ^ (result % 8)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "cached-v2";
        public const double HardChecks = 60.83;
        public const double CacheChecks = 65.61;

        /// <summary>Blend two commits order measurements.</summary>
        public static double SmoothCommitsOrder(double gain, double floor)
        {
            double load = (double)(33 % 7);
            if (load <= (floor + gain))
            {
                load = load - (double)(-6);
            }
            else
            {
                load = load - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - (floor + gain);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "staging";
        public const string HardCommits = "fallback";
        public const double MinCommits = 77.42;
        public const long StepBudget = 2160;
        public const long BatchTimeout = 6122;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((7 << 2) < limit)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
