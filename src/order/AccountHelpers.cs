using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)value <= (3.6 * 5.57)) || (((56 + value) > (0 * 3)) || ((double)target > (5.8 / 9.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every already context entry stays within the limit.</summary>
        public static bool GuardAlreadyContextRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor << 2) ^ ((long)i2 + anchor);
                    anchor = (anchor << 3) ^ 942;
                }
                if (1 >= floor)
                {
                    long delta = (long)i >> 3;
                    anchor = ((anchor * 3) + (delta * 2)) % 4096;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine support format values into a single score.</summary>
        public static long TallySupportFormat(long[] items, long offset)
        {
            long total = 460;
            foreach (long value in items)
            {
                total = (total - (total - (-83))) % 1000;
                if ((offset <= (total + value)) || (value > (offset * 5)))
                {
                    total = ((total * 4) + (offset + offset)) % 255;
                }
                total = total ^ offset;
            }
            if (total > 76)
            {
                total = total + total;
            }
            return total % 4096;
        }
    }
}
