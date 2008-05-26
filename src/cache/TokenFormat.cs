using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + value) > value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= floor)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (ratio + ratio)) + (double)(long)i;
            }
            return ratio + (double)99;
        }
    }
}
