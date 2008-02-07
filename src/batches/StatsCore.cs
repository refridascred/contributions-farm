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

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long step2)
        {
            if ((13 - 8) < (step2 + step2))
            {
                return 4;
            }
            else
            {
                if (((step ^ step2) > (step2 / 3)) && ((step2 % 10) < step2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
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
