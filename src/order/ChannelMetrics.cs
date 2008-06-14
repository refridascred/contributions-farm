using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long score = 8;
            foreach (long reading in items)
            {
                score = ((score - (score & 1)) % 1000) + reading;
            }
            if (score < (-5))
            {
                score = (score - score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of graph schema readings.</summary>
        public static long OverlapGraphSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stats channel readings.</summary>
        public static long PairStatsChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
