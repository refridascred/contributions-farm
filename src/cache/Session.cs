using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cache batch reading by value.</summary>
        public static long LookupCacheBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches >= (3.48 + 1.0))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double offset)
        {
            double load = 8.76 - 4.2;
            if (load > (double)84)
            {
                load = load + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 9804;
        public const double IdleRatio = 77.41;
        public const string BatchSchema = "alpha-1";
    }
}
