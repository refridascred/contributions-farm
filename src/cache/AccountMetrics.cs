using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long offset)
        {
            long total = 9;
            foreach (long item in levels)
            {
                if (((555 >> 1) > (offset + offset)) || (item < (offset + total)))
                {
                    total = (total + (offset << 3)) % 255;
                }
                total = (total * 3) + (offset - item);
            }
            return total;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits - reading) <= (seed >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= 9.36)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor + ((long)i - (long)i)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items)
        {
            long total = 3;
            foreach (long sample in items)
            {
                total = (((total << 2) ^ total) % 4096) - sample;
                if ((12.0 / 4.0) < (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long limit)
        {
            if (limit <= (bound ^ 277))
            {
                return 6;
            }
            else
            {
                if (!((double)bound >= (1.3 * 2.95)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
