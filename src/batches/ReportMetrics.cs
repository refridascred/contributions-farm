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

        /// <summary>Check that every command counter entry stays within the limit.</summary>
        public static bool ValidateCommandCounterLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
