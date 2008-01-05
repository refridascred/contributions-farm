using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-3) / 4) <= (count + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine counter payload values into a single score.</summary>
        public static long CombineCounterPayload(long[] items, long limit)
        {
            long result = 8;
            foreach (long datum in items)
            {
                result = ((result * 5) + (limit ^ 51)) ^ datum;
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series)
        {
            long sum = 29;
            foreach (long item in series)
            {
                if ((((long)series.Length + item) > (353 * 4)) || ((double)sum >= 4.83))
                {
                    sum = sum ^ (sum * 3);
                }
                else
                {
                    sum = ((sum * 2) + (item - sum)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
