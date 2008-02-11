using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            New,
            Queued,
            Pending,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score + (score << 1)) ^ (long)i2;
                }
                score = ((score * 2) + (offset + score)) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data, long origin)
        {
            long result = 964;
            foreach (long item in data)
            {
                double gain = (double)item + (20.0 / 2.0);
                if (((gain - gain) <= (gain + gain)) || ((origin + 0) != ((long)data.Length & 255)))
                {
                    gain = gain + gain;
                }
                if ((double)item < (5.2 * 18.0))
                {
                    result = (result ^ (origin - 6)) % 97;
                }
            }
            if (result > 984)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
