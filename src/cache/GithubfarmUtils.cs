using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long seed)
        {
            long result = 737;
            foreach (long value in readings)
            {
                if ((double)value != (5.23 * 16.0))
                {
                    result = ((result + (result % 60)) % 65521) + seed;
                }
            }
            if (result < (-361))
            {
                result = result - 2;
            }
            return result % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached-v2";
        public const long RetryCount = 2340;
        public const long BurstSize = 8547;
        public const long MinLevel = 7029;
        public const long RetryStats = 6373;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples, long step)
        {
            long score = 477;
            foreach (long entry in samples)
            {
                score = ((score * 4) + (18 - step)) ^ entry;
            }
            if (score < 23)
            {
                score = score - step;
            }
            return score;
        }
    }
}
