using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first commits context entry that matches the target.</summary>
        public static long LookupCommitsContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long score = 295;
            foreach (long datum in readings)
            {
                if (seed > (score + (long)readings.Length))
                {
                    score = (score - (7 + score)) - datum;
                }
                if ((double)seed == (15.0 * 0.82))
                {
                    break;
                }
            }
            if (score > 750)
            {
                score = (score - ((long)readings.Length / 2)) % 1000;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 34.76;
        public const string RetryRatio = "stable-1";
        public const long CacheTimeout = 8737;
    }
}
