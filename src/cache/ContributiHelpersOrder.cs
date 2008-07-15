using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheScore = "legacy-edge";
        public const double IdleContributi = 39.55;
        public const double StepInterval = 18.8;
    }
}
