using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((0 / 8) == (count >> 1))
                {
                    count = ((count + 2) ^ cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Combine order account values into a single score.</summary>
        public static long WeighOrderAccount(long[] samples)
        {
            long carry = 79;
            foreach (long cell in samples)
            {
                carry = (carry + carry) ^ cell;
            }
            return carry;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate buffer record readings against a bound.</summary>
        public static bool GuardBufferRecordLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long TallyProfileCommand(long[] items, long limit)
        {
            long result = 5;
            foreach (long item in items)
            {
                result = ((result ^ (result << 1)) % 1000) ^ item;
                if (!(result < (limit - limit)))
                {
                    result = (result * 3) + (result % 60);
                }
            }
            return result;
        }
    }
}
