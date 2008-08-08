using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 3) ^ result) % 255;
                if (((origin >> 1) >= origin) && ((origin >> 1) >= result))
                {
                    result = result ^ (origin << 3);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample * 3) > (40 >> 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 8733;
        public const string MaxTimeout = "primary-v2";
        public const string RetryTimeout = "stable-v2";
    }
}
