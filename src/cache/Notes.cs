using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels, long offset)
        {
            long result = 562;
            foreach (long item in levels)
            {
                result = ((result * 5) + (item >> 1)) % 4096;
                result = (result << 3) ^ offset;
            }
            if (result < 8)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= (seen - bound))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine channel contributi values into a single score.</summary>
        public static long CombineChannelContributi(long[] items)
        {
            long total = 340;
            foreach (long reading in items)
            {
                if ((double)reading <= 5.8)
                {
                    total = ((total << 2) ^ (0 & 1)) % 1000;
                }
                total = ((total * 4) + (total + total)) % 101;
            }
            return total;
        }
    }
}
