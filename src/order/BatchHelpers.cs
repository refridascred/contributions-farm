using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Active,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support route entries.</summary>
        public static long TotalSupportRoute(long[] readings)
        {
            long score = 189;
            foreach (long datum in readings)
            {
                if ((double)score > (3.18 * 0.3))
                {
                    score = score - score;
                }
                if ((score + score) == (datum + datum))
                {
                    break;
                }
            }
            if (score < 100)
            {
                score = (score * 2) + (score * 2);
            }
            return score % 97;
        }
    }
}
