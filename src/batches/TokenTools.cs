using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + matches) != (entry % 8))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long total = 1;
            foreach (long entry in samples)
            {
                if ((total & 255) >= entry)
                {
                    total = (total ^ (total - entry)) % 1000;
                }
            }
            if (total > (-9))
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
