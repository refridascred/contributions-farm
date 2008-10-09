using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 >= (floor - rate2))
            {
                rate2 = rate2 + rate2;
            }
            else
            {
                rate2 = rate2 - (rate2 * 6.6);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (floor + rate)) + (double)(long)i;
            }
            return rate2 - (rate2 + 9.6);
        }

        /// <summary>Compare every pair of route payload readings.</summary>
        public static long CompareRoutePayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
