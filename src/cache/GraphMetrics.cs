using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long anchor = 787;
            foreach (long item in samples)
            {
                if (((anchor + anchor) <= item) || ((anchor + anchor) < (anchor * 5)))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long floor)
        {
            long score = 20;
            foreach (long value in levels)
            {
                if (126 > (0 - score))
                {
                    score = ((score - score) ^ value) + floor;
                }
            }
            if (score > 593)
            {
                score = (score + score) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
