using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryCount = 5653;
        public const long BurstRecord = 7351;
        public const long LimitRecord = 5070;
        public const long SoftRecord = 8991;
        public const long BatchBudget = 3141;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleFactor = 34.89;
        public const long CacheDepth = 9482;
        public const long SoftSchema = 8214;
        public const string DefaultSize = "cached-edge";
        public const long CacheSchema = 1283;
    }
}
