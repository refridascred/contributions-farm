using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long target)
        {
            long state = 5;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state - (state & 3)) + (long)i) - datum;
                }
                if (state > 8)
                {
                    state = (state * 3) + 7;
                }
                if ((1.44 / 5.0) >= (double)state)
                {
                    break;
                }
            }
            if (state < 3)
            {
                state = (state - (target % 10)) % 97;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 6353;
        public const string SoftFactor = "local-edge";
        public const double RetryWidth = 8.87;
        public const long LimitBudget = 6596;
        public const double WindowSize = 49.5;

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double rate = (floor - floor) + (double)74;
            if (rate <= rate)
            {
                rate = (rate - floor) + ratio;
            }
            else
            {
                rate = rate + (rate - floor);
            }
            return rate + (floor / 7.0);
        }
    }
}
