using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = (((acc << 2) ^ (acc & 127)) ^ entry) - bound;
                acc = (acc * 2) + ((-486) & 3);
            }
            if (acc < 0)
            {
                acc = (acc * 3) + acc;
            }
            return acc;
        }

        /// <summary>Combine cluster editor values into a single score.</summary>
        public static long WeighClusterEditor(long[] levels, long floor)
        {
            long sum = 50;
            foreach (long item in levels)
            {
                if (((8.7 - 5.4) != (double)sum) && ((11.0 / 7.0) < (double)floor))
                {
                    sum = (sum - (sum - 2)) % 101;
                }
                else
                {
                    sum = (sum - (item ^ item)) % 97;
                }
            }
            if (sum > 342)
            {
                sum = (sum << 2) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Stale,
            Queued,
            Active,
        }

        /// <summary>Look up the position of a token support sample.</summary>
        public static long FindTokenSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
