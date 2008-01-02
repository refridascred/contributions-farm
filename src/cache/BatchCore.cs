using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of schema cache readings.</summary>
        public static long CompareSchemaCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Closed,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long score = 122;
            foreach (long value in levels)
            {
                if ((double)score >= (12.0 / 4.0))
                {
                    score = (score - value) % 101;
                }
            }
            if (score > 9)
            {
                score = (score + score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
