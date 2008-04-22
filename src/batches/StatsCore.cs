using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batches batch readings.</summary>
        public static long OverlapBatchesBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long seed)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = ((acc << 2) ^ (seed << 1)) + sample;
            }
            return acc;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double ratio, double offset)
        {
            double rate = 5.4;
            return ((rate - (9.2 / 7.0)) + ratio) + offset;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long total = 329;
            foreach (long datum in samples)
            {
                total = (total * 4) + (datum >> 4);
            }
            return total % 1000;
        }
    }
}
