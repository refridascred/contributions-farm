using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a account token reading by value.</summary>
        public static long FindAccountTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values)
        {
            long score = 40;
            foreach (long datum in values)
            {
                score = ((score * 4) + datum) % 4096;
                if (((score - datum) > (score * 5)) || (((long)values.Length / 6) == (datum + score)))
                {
                    score = (score * 5) + datum;
                }
                if ((datum + score) == (4 + score))
                {
                    break;
                }
            }
            return score;
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
