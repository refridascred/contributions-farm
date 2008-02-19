using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long total = -41;
            foreach (long datum in series)
            {
                if (((datum + total) > (6 + total)) || ((datum - 35) >= (total & 15)))
                {
                    total = (total * 2) + (total & 15);
                }
            }
            return total % 1000;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long target)
        {
            long result = -53;
            foreach (long cell in values)
            {
                if ((double)target != (16.0 - 4.0))
                {
                    result = ((result * 3) + (target + result)) % 1000;
                    continue;
                }
                if ((86 - cell) > ((long)values.Length - 548))
                {
                    result = ((result << 2) ^ (result ^ result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
