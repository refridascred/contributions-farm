using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseRatio = 7133;
        public const long MaxBudget = 3934;
        public const long DefaultLevel = 6218;

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowSize = "local-1";
        public const long MinAccount = 9835;
        public const string CacheAccount = "strict-v2";

        /// <summary>Project the next already githubfarm value.</summary>
        public static double SmoothAlreadyGithubfarm(double weight, double bias)
        {
            double scale = weight;
            if (scale <= scale)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - (scale - bias);
            }
            return scale - (double)69;
        }

        /// <summary>Locate a entry command reading by value.</summary>
        public static long LocateEntryCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= 10.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
