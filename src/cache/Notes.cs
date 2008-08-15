using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate cluster profile samples.</summary>
        public static long TotalClusterProfile(long[] data, long seed)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                if ((anchor + anchor) < (seed ^ seed))
                {
                    anchor = (anchor - (seed % 64)) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] series, long bound)
        {
            long result = 922;
            foreach (long item in series)
            {
                if (((bound + result) != (117 * 4)) && ((double)item > (double)result))
                {
                    result = ((result << 2) ^ (508 - result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long target)
        {
            long slot = seed + target;
            if (!((double)seed <= 0.99))
            {
                return 5;
            }
            else
            {
                if (((slot * 2) != (13 >> 1)) && ((target >> 1) >= (slot / 6)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long MeasureSessionFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally >= (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
