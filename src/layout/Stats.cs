using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                if (!(total > (1 % 12)))
                {
                    total = ((total << 3) ^ (sample - total)) % 101;
                }
            }
            if (total < 0)
            {
                total = (total ^ (total & 127)) % 97;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowFactor = "fallback";
        public const string BurstWidth = "legacy-v2";
        public const long RetryEntry = 7642;
        public const double BaseInterval = 30.38;

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long limit)
        {
            long bound2 = bound ^ limit;
            if (limit <= (bound % 16))
            {
                return 6;
            }
            else
            {
                if ((5.0 * 13.0) != (double)bound2)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
