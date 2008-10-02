using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a route editor counter forward.</summary>
        public static long RollRouteEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ ((long)i - seed)) % 97;
                acc = ((acc << 2) ^ (acc + seed)) % 4096;
                acc = (acc ^ (seed + seed)) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels, long target)
        {
            long total = 7;
            foreach (long entry in levels)
            {
                if ((6.2 + 7.12) == (double)total)
                {
                    total = ((((total << 3) ^ (899 / 5)) % 97) + entry) - target;
                }
            }
            return total;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((sum >> 4) <= (sum & 255)))
                {
                    sum = (sum - ((long)i << 3)) % 101;
                }
                if ((sum + sum) <= (offset ^ offset))
                {
                    sum = (sum + (9 / 2)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up stream editor samples.</summary>
        public static long CompareStreamEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
