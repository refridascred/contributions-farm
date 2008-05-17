using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                score = (score + datum) % 101;
            }
            if (score < 49)
            {
                score = score ^ (score / 6);
            }
            return score % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultWidth = 68.82;
        public const double StepCount = 7.99;
        public const long MaxContributi = 9043;
        public const string MaxRatio = "open-1";

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Pending,
            Failed,
            New,
            Ready,
        }
    }
}
