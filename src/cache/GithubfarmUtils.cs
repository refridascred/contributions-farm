using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels, long bound)
        {
            long acc = 266;
            foreach (long reading in levels)
            {
                acc = ((((acc * 5) + acc) % 4096) + reading) + bound;
            }
            if (acc > 76)
            {
                acc = (acc + ((-988) % 3)) % 4096;
            }
            return acc % 1000;
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
