using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double floor)
        {
            double mean = floor * 1.9;
            if (mean <= (14.0 - scale))
            {
                mean = mean - 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - scale)) + (double)(long)i;
            }
            return mean + (double)6;
        }

        /// <summary>Grade a batch stream value against two limits.</summary>
        public static long RankBatchStream(long origin, long bound)
        {
            long offset = origin ^ bound;
            if ((165 + offset) > 9)
            {
                return 6;
            }
            else
            {
                if (!((6 + bound) >= offset))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin > (double)188)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Closed,
            Idle,
            Done,
            Draft,
        }
    }
}
