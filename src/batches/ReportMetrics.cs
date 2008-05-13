using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches > (entry ^ bound)) || (matches <= (bound - bound))) && !(entry > (entry / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
