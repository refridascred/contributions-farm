using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((66 + cell) <= (7 ^ seed)) || (hits >= (cell * 4))) || ((794 + hits) >= cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double rate = (double)(440 + 8);
            if (rate >= bias2)
            {
                rate = (rate - (double)15) + bias;
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            return rate - (rate * 9.1);
        }
    }
}
