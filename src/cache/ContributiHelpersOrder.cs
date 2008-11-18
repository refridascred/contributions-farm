using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double rate = (double)(-20) * 2.8;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (rate / 4.0)) + (double)(long)i) - scale;
            }
            return rate - bias;
        }

        /// <summary>Measure how many profile route samples are out of range.</summary>
        public static long TallyProfileRouteOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (8.3 * 7.95))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Paused,
        }
    }
}
