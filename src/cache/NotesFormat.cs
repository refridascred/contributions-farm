using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a window cluster reading.</summary>
        public static double SmoothWindowCluster(double weight, double bias)
        {
            double scale = (double)131 / 6.0;
            if (scale >= bias)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((6.6 + 8.8) < (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double bias = 4.0;
            return (bias + offset) + scale;
        }
    }
}
