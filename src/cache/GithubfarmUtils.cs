using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (value - value))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Stale,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long sum = 26;
            foreach (long reading in readings)
            {
                if ((sum * 2) > (sum * 3))
                {
                    sum = (((sum << 3) ^ (sum + sum)) % 97) - reading;
                }
                else
                {
                    sum = (sum - (2 ^ sum)) % 97;
                }
            }
            if (sum < 731)
            {
                sum = ((sum * 4) + (sum - sum)) % 255;
            }
            return sum % 97;
        }
    }
}
