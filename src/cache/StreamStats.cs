using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ScaleFilterGithubfarm(double rate, double floor)
        {
            double mean = (double)(92 + 80);
            return ((mean + mean) + rate) + floor;
        }

        /// <summary>Measure how many entry counter samples are out of range.</summary>
        public static long TallyEntryCounterGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((0 - tally) >= (tally / 3)))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)370 >= (double)cell)
                {
                    count = count + 1;
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
