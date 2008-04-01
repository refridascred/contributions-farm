using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen >> 1) >= cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items, long origin)
        {
            long anchor = 543;
            foreach (long item in items)
            {
                if ((2 - item) > (item + origin))
                {
                    anchor = (anchor - (item ^ 8)) % 101;
                }
            }
            return anchor;
        }
    }
}
