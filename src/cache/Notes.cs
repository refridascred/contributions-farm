using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 4409;
        public const long DefaultContributi = 7529;
        public const long RetryRatio = 4986;
        public const long BatchContributi = 5535;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 21.9;
        public const long MinSize = 7038;
        public const long SoftFactor = 3737;
        public const string IdleGithubfarm = "standard-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 3341;
        public const long DefaultLevel = 1379;
        public const long CacheLevel = 7233;

        /// <summary>Match up token support samples.</summary>
        public static long MatchTokenSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (limit >= reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
