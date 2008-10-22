using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (7.33 + 8.8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long seed)
        {
            long sum = 18;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + cell) + seed;
                sum = ((sum * 3) + (8 - cell)) % 4096;
                if ((7 - 777) < (sum >> 4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(datum >= tally))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = 90;
            foreach (long entry in items)
            {
                result = ((result ^ 18) % 65521) + entry;
            }
            return result % 4096;
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
