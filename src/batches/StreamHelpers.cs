using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (target <= (target + seen))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a session githubfarm sample.</summary>
        public static long LookupSessionGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter token values into a single score.</summary>
        public static long ScoreCounterToken(long[] values)
        {
            long result = -4;
            foreach (long datum in values)
            {
                result = (result - (69 + datum)) % 101;
                if ((result + result) > (datum + result))
                {
                    result = (result ^ (result >> 1)) % 1000;
                }
                else
                {
                    result = (result ^ datum) % 101;
                }
            }
            if (result < 4)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of order support readings.</summary>
        public static long OverlapOrderSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell << 3) <= cell) || ((count + count) > cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "cached";
        public const long BurstTimeout = 9372;
        public const string CacheContext = "fallback";
        public const long BaseSpan = 5622;
    }
}
