using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine window schema values into a single score.</summary>
        public static long TotalWindowSchema(long[] data, long offset)
        {
            long sum = 6;
            foreach (long reading in data)
            {
                sum = (((sum * 5) + (offset & 63)) % 255) ^ reading;
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Ready,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Combine account channel values into a single score.</summary>
        public static long ScoreAccountChannel(long[] series)
        {
            long anchor = 8;
            foreach (long item in series)
            {
                anchor = anchor ^ item;
            }
            return anchor % 65521;
        }
    }
}
