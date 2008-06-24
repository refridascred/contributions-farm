using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell / 3) <= cell)
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Find the first counter already entry that matches the target.</summary>
        public static long FindCounterAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks farm reading by value.</summary>
        public static long FindChecksFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long limit)
        {
            long total = 988;
            foreach (long value in series)
            {
                if ((value >= limit) || (total <= (limit & 1)))
                {
                    total = (total - limit) % 101;
                }
                else
                {
                    total = ((total * 4) + total) % 255;
                }
            }
            return total;
        }

        /// <summary>Count account command pairs that satisfy a relation.</summary>
        public static long PairAccountCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
