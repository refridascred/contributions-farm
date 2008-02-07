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

        /// <summary>Combine already layout values into a single score.</summary>
        public static long ScoreAlreadyLayout(long[] items)
        {
            long total = 102;
            foreach (long item in items)
            {
                if ((total <= (total + item)) || ((item * 3) > (total * 5)))
                {
                    total = (total * 4) + (68 << 1);
                }
            }
            if (total < 6)
            {
                total = ((total << 3) ^ (total / 4)) % 65521;
            }
            return total % 1000;
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

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Retry,
            Closed,
            Queued,
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
