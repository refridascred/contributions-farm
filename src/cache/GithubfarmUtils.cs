using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items)
        {
            long acc = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((((acc * 3) + (acc << 1)) % 65521) ^ (long)i) + value;
                }
                if ((13 << 3) > acc)
                {
                    acc = (acc - ((-7) + 243)) % 255;
                }
            }
            if (acc > 696)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Measure how many batch stream samples are out of range.</summary>
        public static long CountBatchStreamHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= ((long)data.Length + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((origin + origin) > origin)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Paused,
            Draft,
            Dropped,
        }
    }
}
