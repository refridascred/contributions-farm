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

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 20.74;
        public const long SoftSize = 6093;
        public const long BaseLevel = 4732;
        public const double BurstFactor = 15.28;
        public const double WindowSession = 26.85;

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
