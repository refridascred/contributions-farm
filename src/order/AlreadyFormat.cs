using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double offset)
        {
            double mean = weight;
            if (mean >= (mean + weight))
            {
                mean = mean - (double)883;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean / 3.0)) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - 337) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long offset)
        {
            long mark = 64;
            foreach (long reading in series)
            {
                mark = (mark + (offset % 12)) + reading;
            }
            if (mark < 8)
            {
                mark = (mark ^ ((-2) << 2)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Closed,
            Failed,
            Retry,
            Ready,
        }
    }
}
