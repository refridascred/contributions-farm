using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 7595;
        public const long LimitInterval = 8825;
        public const long WindowContributi = 9948;
        public const long SoftWidth = 8751;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleRatio = 7389;
        public const string MaxSize = "legacy-1";
        public const string HardCommits = "legacy-v2";
        public const long CacheBudget = 1971;
        public const long IdleCommits = 4038;

        /// <summary>Validate format layout readings against a bound.</summary>
        public static bool VerifyFormatLayoutRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
