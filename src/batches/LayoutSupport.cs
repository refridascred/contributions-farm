using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double scale = (rate / 2.0) - bias;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (6.64 + scale)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long total = -60;
            foreach (long value in items)
            {
                total = total - (value * 3);
            }
            return total % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((18 + count) == (entry & 255))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = (score ^ ((long)i * 4)) % 101;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
