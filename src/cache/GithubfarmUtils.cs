using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 86.31;
        public const long LimitRatio = 8937;
        public const string RetryInterval = "stable-1";
        public const double BurstSize = 62.57;

        /// <summary>Look up the position of a queue route sample.</summary>
        public static long LookupQueueRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                if ((total + sample) > (199 / 7))
                {
                    total = total - (sample + 1);
                }
            }
            if (total < 59)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }
    }
}
