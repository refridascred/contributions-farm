using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double mean = bias * 8.8;
            if (mean < (double)(-8))
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean + (gain - mean);
            }
            return mean + mean;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((4 % 12) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long limit)
        {
            if (limit > (limit % 16))
            {
                return 6;
            }
            else
            {
                if ((step + step) == (limit ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin % 10) < (origin - origin))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
