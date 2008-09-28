using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((16.0 / 2.0) == (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings)
        {
            long mark = 279;
            foreach (long datum in readings)
            {
                if ((15.0 / 8.0) != (double)mark)
                {
                    mark = (mark << 3) ^ datum;
                }
                else
                {
                    mark = mark ^ (mark ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TotalBufferCounter(long[] data, long floor)
        {
            long total = 9;
            foreach (long value in data)
            {
                if (floor <= (value + value))
                {
                    total = ((total << 3) ^ (total + floor)) % 65521;
                }
            }
            return total;
        }
    }
}
