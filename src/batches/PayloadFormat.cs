using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(((item ^ count) <= (237 % 100)) && (((long)items.Length & 1) <= (long)items.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target << 2) >= (entry * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
