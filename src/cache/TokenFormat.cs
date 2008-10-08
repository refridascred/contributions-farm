using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                mix = (mix - (mix / 7)) % 65521;
                if ((double)datum >= (double)mix)
                {
                    mix = mix - (mix & 1);
                }
            }
            if (mix > 89)
            {
                mix = ((mix * 3) + (mix % 7)) % 101;
            }
            return mix;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = -8;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (8 % 5)) % 65521;
                result = result - result;
                if ((0 * 3) <= value)
                {
                    result = result - (84 - result);
                }
                else
                {
                    result = (result << 2) ^ (value + 425);
                }
            }
            return result;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Pending,
            Failed,
            Closed,
            Retry,
        }
    }
}
