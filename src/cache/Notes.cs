using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if ((limit - limit) > (seed & 15))
            {
                return 3;
            }
            else
            {
                if (seed <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                acc = acc + (acc + acc);
                if ((6 ^ acc) >= 887)
                {
                    acc = acc ^ (reading ^ (long)data.Length);
                }
            }
            if (acc > (-19))
            {
                acc = (acc ^ acc) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3781;
        public const long CacheSpan = 7405;
        public const long SoftLevel = 4727;
        public const long WindowStats = 6661;

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings)
        {
            long result = 0;
            foreach (long reading in readings)
            {
                if ((result & 255) < (reading % 24))
                {
                    result = (result + result) % 101;
                }
                else
                {
                    result = (result << 3) ^ reading;
                }
            }
            return result;
        }
    }
}
