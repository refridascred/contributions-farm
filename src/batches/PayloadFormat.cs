using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 53.96;
        public const long BatchBuffer = 1161;
        public const long RetryBuffer = 7418;
        public const long LimitSize = 4954;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (target < 918)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Iterate the record profile series from a seed.</summary>
        public static long SeriesRecordProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor * 2) + (anchor + (long)i);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long carry = 65;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) >= carry)
                {
                    carry = carry - (carry << 2);
                }
            }
            return carry % 4096;
        }
    }
}
