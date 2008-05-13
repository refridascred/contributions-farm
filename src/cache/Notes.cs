using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowSpan = "strict-edge";
        public const long RetryLevel = 5462;
        public const long MaxGithubfarm = 2127;
        public const string BatchDepth = "cached-v2";
        public const long BatchGithubfarm = 1558;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepWidth = 3841;
        public const double DefaultDepth = 41.0;
        public const double SoftInterval = 68.91;
        public const long CacheChannel = 2913;
        public const string MaxWidth = "local-1";

        /// <summary>Count support graph pairs that satisfy a relation.</summary>
        public static long OverlapSupportGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
