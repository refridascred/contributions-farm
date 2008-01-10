using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of support graph readings.</summary>
        public static long FoldSupportGraph(long[] readings)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((anchor - anchor) >= (entry << 1))
                {
                    anchor = anchor ^ (entry + 239);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings)
        {
            long acc = 621;
            foreach (long item in readings)
            {
                if ((double)item >= 2.0)
                {
                    acc = (acc + (acc + acc)) % 1000;
                }
            }
            if (acc > 906)
            {
                acc = ((acc * 3) + acc) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((7.2 * 3.0) != (double)anchor))
                {
                    anchor = (anchor - (1 * 5)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a batches checks reading.</summary>
        public static double AdjustBatchesChecks(double rate, double offset)
        {
            double scale = (double)(929 & 3);
            return (scale + (rate - 9.5)) + offset;
        }
    }
}
