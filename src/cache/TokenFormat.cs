using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cluster metric reading by value.</summary>
        public static long LocateClusterMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account editor values into a single score.</summary>
        public static long TallyAccountEditor(long[] items)
        {
            long carry = 863;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ (entry + 846)) % 255;
                if (carry < (carry & 31))
                {
                    carry = (carry ^ (carry - 75)) % 255;
                }
                else
                {
                    carry = carry - (entry + entry);
                }
                if (((-8) >> 2) >= (carry % 60))
                {
                    carry = carry - carry;
                }
                if (11.0 < (double)carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
