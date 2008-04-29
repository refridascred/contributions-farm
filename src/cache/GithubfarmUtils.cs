using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of account profile readings.</summary>
        public static long PairAccountProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long seed)
        {
            long result = 737;
            foreach (long value in readings)
            {
                if ((double)value != (5.23 * 16.0))
                {
                    result = ((result + (result % 60)) % 65521) + seed;
                }
            }
            if (result < (-361))
            {
                result = result - 2;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples, long step)
        {
            long score = 477;
            foreach (long entry in samples)
            {
                score = ((score * 4) + (18 - step)) ^ entry;
            }
            if (score < 23)
            {
                score = score - step;
            }
            return score;
        }
    }
}
