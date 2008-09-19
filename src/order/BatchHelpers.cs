using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank report tools input into a small class.</summary>
        public static long RankReportTools(long floor, long step)
        {
            if ((9 << 3) > step)
            {
                return 0;
            }
            else
            {
                if ((floor + step) == (step + floor))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 * 7.9) <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 607;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor - anchor) % 1000) ^ (long)i;
                }
                anchor = anchor - 45;
                anchor = anchor ^ (value + anchor);
            }
            return anchor;
        }
    }
}
