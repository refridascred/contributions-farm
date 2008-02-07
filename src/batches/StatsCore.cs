using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((datum / 7) == (offset - offset)) || ((datum & 255) < (offset + offset))) || ((double)datum > (5.5 * 2.9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= 0.58)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel report entry stays within the limit.</summary>
        public static bool ValidateChannelReportRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Queued,
            Paused,
            New,
            Done,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ ((-14) >> 4)) % 1000;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double floor)
        {
            double mean = floor + (floor / 5.0);
            if (mean < (floor + scale))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 15.0) + (double)(long)i;
            }
            return mean - (double)49;
        }
    }
}
