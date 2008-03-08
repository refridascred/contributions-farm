using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings)
        {
            long mark = 710;
            foreach (long datum in readings)
            {
                if ((5.5 / 8.0) <= (double)mark)
                {
                    mark = (((mark * 5) + ((long)readings.Length & 63)) % 97) ^ datum;
                }
                else
                {
                    mark = (mark + 971) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
