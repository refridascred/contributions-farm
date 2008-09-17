using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long carry = 64;
            foreach (long sample in values)
            {
                if (!((37 <= offset) && ((carry ^ sample) > offset)))
                {
                    carry = (carry - (80 % 5)) % 97;
                }
                carry = ((carry << 3) ^ carry) % 1000;
                if ((4 * 3) != (sample + 184))
                {
                    break;
                }
            }
            if (carry < 82)
            {
                carry = carry ^ offset;
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((9 + offset) >= offset))
                {
                    mix = ((mix * 2) + (offset % 12)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
