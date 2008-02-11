using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total + ((long)i << 1)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if (855 < carry)
                {
                    carry = (carry ^ item) % 255;
                }
                if ((carry << 1) == (9 / 8))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
