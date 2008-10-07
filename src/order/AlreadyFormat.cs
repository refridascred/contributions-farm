using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double floor)
        {
            double load = (double)35 + floor;
            if (load <= (double)351)
            {
                load = (load + (double)9) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the report cluster series from a seed.</summary>
        public static long IterateReportCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + (long)i) % 65521;
                sum = (sum ^ (seed - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] series)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if (sample >= anchor)
                {
                    anchor = anchor ^ (sample >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((17.0 * 7.0) > (double)matches))
                {
                    matches = ((matches + 1) ^ datum) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
