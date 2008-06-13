using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double gain2 = (double)((-51) + 1);
            if (gain2 >= (double)820)
            {
                gain2 = (gain2 + gain) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 + (gain * 0.26);
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
