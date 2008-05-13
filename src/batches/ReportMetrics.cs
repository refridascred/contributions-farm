using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long seed, long offset)
        {
            if ((seed + 289) <= seed)
            {
                return 0;
            }
            else
            {
                if (seed >= (seed & 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            New,
            Failed,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 > (8.2 - floor))
            {
                bias2 = bias2 - (floor / 7.0);
            }
            return bias2 - (bias - bias2);
        }
    }
}
