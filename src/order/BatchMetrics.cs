using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean - offset)) + (double)(long)i;
            }
            return mean + (rate + 14.0);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((3 & 1) >= (carry + (long)i))
                {
                    carry = (carry - (carry - 57)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 10) > seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Done,
            Dropped,
            Paused,
        }
    }
}
