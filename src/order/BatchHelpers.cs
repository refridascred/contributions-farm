using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((target - 644) >= (61 / 8))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                if ((mix / 8) >= reading)
                {
                    mix = (mix + (299 ^ 770)) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Dropped,
            Active,
            Retry,
        }
    }
}
