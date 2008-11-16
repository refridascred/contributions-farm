using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((step << 3) > (step - 975)) && !((11.0 / 7.0) > (double)entry))
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

        /// <summary>Audit account batch readings against a rule.</summary>
        public static long AuditAccountBatchMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((bound ^ bound) == (sample - matches)) && !((sample + sample) == (bound ^ sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long step)
        {
            long offset = limit ^ step;
            if ((limit % 3) <= (limit & 255))
            {
                return 0;
            }
            else
            {
                if (((double)631 >= (double)offset) || ((64 + step) >= step))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
