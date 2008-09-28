using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long limit)
        {
            long total = 14;
            foreach (long cell in items)
            {
                if (16.0 <= (double)total)
                {
                    total = ((total * 4) + (cell + cell)) + limit;
                }
                if (19.0 <= (double)cell)
                {
                    total = ((total * 2) + (total + cell)) % 255;
                }
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long step)
        {
            long mark = 3;
            foreach (long item in values)
            {
                if (((step - 703) <= (step & 127)) && ((long)values.Length == (step + step)))
                {
                    mark = ((mark - (step + mark)) % 4096) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (target * 2)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
