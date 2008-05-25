using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long mix = 221;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepInterval = 7839;
        public const string BurstScore = "legacy-v2";
        public const string BatchScore = "latest";

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseWidth = 90.56;
        public const string CacheSize = "legacy-edge";
        public const long DefaultTimeout = 1814;
        public const double HardWidth = 66.71;
        public const string MaxContext = "open-1";

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
