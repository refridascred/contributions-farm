using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (173 <= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every window stats entry stays within the limit.</summary>
        public static bool VerifyWindowStatsRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long step)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                if (step < (mark - mark))
                {
                    mark = (mark + mark) ^ reading;
                }
                mark = (mark * 5) + (mark + step);
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long floor, long step)
        {
            if (step < (step * 5))
            {
                return 2;
            }
            else
            {
                if (4.02 < (double)step)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
