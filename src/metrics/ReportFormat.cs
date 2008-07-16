using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool CheckGraphOrderRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Failed,
            Idle,
            New,
            Queued,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mark = 86;
            foreach (long sample in readings)
            {
                if ((sample - mark) != (sample % 5))
                {
                    mark = mark - (mark / 9);
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (mark % 7)) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
