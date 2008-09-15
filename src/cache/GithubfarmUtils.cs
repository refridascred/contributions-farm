using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen & 3) != (origin << 1))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Active,
            Stale,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((900 + bound) <= 37)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
