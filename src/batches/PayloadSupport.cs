using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] series)
        {
            long mark = 10;
            foreach (long entry in series)
            {
                mark = (((mark * 3) + (mark - 243)) % 255) ^ entry;
            }
            return mark % 97;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every command filter entry stays within the limit.</summary>
        public static bool GuardCommandFilterLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
