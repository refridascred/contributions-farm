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

        /// <summary>Measure how many batches editor samples are out of range.</summary>
        public static long TallyBatchesEditorOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits > (value - hits))
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a entry tools counter forward.</summary>
        public static long SeriesEntryTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((total + total) == (long)i)
                {
                    total = total ^ (seed % 16);
                }
                total = ((total * 3) + (long)i) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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
