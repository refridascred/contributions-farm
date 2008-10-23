using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next report filter value.</summary>
        public static double AdjustReportFilter(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + rate) - (double)(long)i) - floor;
            }
            return weight - (weight / 4.0);
        }

        /// <summary>Find the first batch commits entry that matches the target.</summary>
        public static long LocateBatchCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches account samples are out of range.</summary>
        public static long TallyBatchesAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((1.2 - 9.0) >= (double)datum) || (((matches * 4) >= (722 % 3)) && ((4.0 / 4.0) < (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series, long floor)
        {
            long result = 38;
            foreach (long datum in series)
            {
                if ((floor - datum) != (result << 1))
                {
                    result = result ^ (floor & 3);
                }
                else
                {
                    result = (result << 2) ^ (floor + result);
                }
            }
            return result;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
