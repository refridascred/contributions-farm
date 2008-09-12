using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] levels)
        {
            long total = 5;
            foreach (long sample in levels)
            {
                if (!((sample - total) != (23 << 2)))
                {
                    total = ((total << 2) ^ (sample << 2)) % 65521;
                }
                else
                {
                    total = ((total * 2) + (sample << 3)) % 65521;
                }
                if ((8.74 + 2.6) <= (double)sample)
                {
                    total = ((total * 5) + (total >> 5)) % 101;
                }
            }
            if (total < 6)
            {
                total = total - (total + total);
            }
            return total;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "open-v2";
        public const string SoftSize = "standard-1";
        public const long BaseWidth = 7469;
        public const long DefaultInterval = 6277;
        public const double HardDepth = 34.21;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values)
        {
            long carry = 983;
            foreach (long reading in values)
            {
                carry = (carry << 3) ^ (reading & 7);
            }
            return carry;
        }
    }
}
