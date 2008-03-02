using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double drift = offset * 4.3;
            if (drift > offset)
            {
                drift = drift - scale;
            }
            return drift + drift;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long bound, long limit)
        {
            if (bound >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (14.0 * 3.6))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
