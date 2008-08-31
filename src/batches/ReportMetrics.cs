using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double ratio2 = (double)49 * 5.0;
            if (ratio2 > 1.9)
            {
                ratio2 = (ratio2 - (double)892) - ratio;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 + (bias * 1.4);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            New,
            Idle,
            Locked,
            Closed,
        }
    }
}
