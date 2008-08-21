using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] series)
        {
            long anchor = 902;
            foreach (long entry in series)
            {
                anchor = anchor ^ (entry << 1);
                if ((double)anchor <= (4.0 - 10.0))
                {
                    anchor = anchor ^ anchor;
                }
                if ((entry + 752) <= (anchor + entry))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor ^ (anchor / 8)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((double)hits > (1.0 / 2.0)))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long seed)
        {
            long result = 95;
            foreach (long item in levels)
            {
                if ((item >= (item + seed)) && ((double)result == (1.38 * 5.78)))
                {
                    result = (result + (seed >> 5)) % 97;
                    result = (result ^ seed) % 101;
                }
                if ((double)seed <= (double)result)
                {
                    result = (result ^ (result ^ item)) % 4096;
                }
                if ((double)result > 1.0)
                {
                    break;
                }
            }
            if (result < 43)
            {
                result = (result << 2) ^ seed;
            }
            return result;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload stream samples.</summary>
        public static long MatchPayloadStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
