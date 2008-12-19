using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long total = 18;
            foreach (long reading in samples)
            {
                if (!((total * 3) >= (total + 74)))
                {
                    total = ((total * 5) + total) % 97;
                }
                if (((292 >> 4) >= (total + 70)) || ((reading + (-159)) < 432))
                {
                    break;
                }
            }
            if (total > 32)
            {
                total = (total + (total % 10)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of metrics layout readings.</summary>
        public static long WeighMetricsLayout(long[] readings)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = total - (9 / 5);
                total = total ^ (24 & 31);
                if ((cell / 4) > (total + cell))
                {
                    total = (total + ((long)readings.Length + 250)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((seed * 2) >= reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
