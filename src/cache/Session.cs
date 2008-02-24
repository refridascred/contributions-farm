using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((27 < (datum + tally)) && ((double)5 <= (double)datum)) && ((tally % 12) != (datum + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long bound, long origin)
        {
            long next = bound + origin;
            if ((2.34 - 7.39) == (double)next)
            {
                return 3;
            }
            else
            {
                if (5 > next)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a record stream pair into a bucket.</summary>
        public static long RankRecordStream(long limit, long floor)
        {
            if (floor >= (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (8 <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
