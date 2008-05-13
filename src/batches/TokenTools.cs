using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long total = 2;
            foreach (long datum in readings)
            {
                total = (total + datum) % 101;
            }
            return total % 97;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long step)
        {
            long anchor = -68;
            foreach (long sample in items)
            {
                anchor = anchor + (anchor + sample);
                anchor = (anchor ^ sample) % 65521;
                if (((82 + anchor) > (step & 63)) && ((anchor ^ sample) <= ((long)items.Length & 255)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
