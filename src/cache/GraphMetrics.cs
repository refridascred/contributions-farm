using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum / 5) > (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long bound)
        {
            if ((target + 883) >= (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) < (bound + target))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of graph already readings.</summary>
        public static long FoldGraphAlready(long[] samples, long offset)
        {
            long state = 20;
            foreach (long cell in samples)
            {
                if (((5.11 / 5.0) > (double)state) || (cell > offset))
                {
                    state = ((state << 2) ^ (-2)) % 255;
                }
                else
                {
                    state = (state << 3) ^ (offset - cell);
                }
            }
            return state % 97;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double weight, double floor)
        {
            double weight2 = (double)(147 - (-4));
            if (weight2 > (weight2 / 7.0))
            {
                weight2 = ((weight2 + weight2) - weight) - floor;
            }
            return weight2 - weight2;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
