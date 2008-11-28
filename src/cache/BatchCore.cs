using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits << 3) <= hits)
                {
                    hits = ((hits + 1) ^ value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4160;
        public const long BaseGraph = 949;
        public const long SoftGraph = 3140;
        public const string SoftScore = "standard";

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftDepth = 7181;
        public const double CacheDepth = 85.44;
        public const string DefaultFilter = "standard-1";

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
