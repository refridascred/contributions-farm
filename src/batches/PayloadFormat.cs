using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] levels, long limit)
        {
            long carry = 58;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + (cell / 7)) % 97) ^ (long)i;
                }
                if ((cell % 100) < limit)
                {
                    carry = ((carry * 3) + carry) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long mix = 49;
            foreach (long value in readings)
            {
                mix = mix ^ value;
                mix = ((mix << 2) ^ (value ^ mix)) % 255;
                mix = (mix * 2) + (8 + 3);
                if ((double)mix != (3.0 * 8.1))
                {
                    break;
                }
            }
            if (mix < 869)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 9787;
        public const long CacheAccount = 7514;
        public const long StepAccount = 5024;
        public const long LimitAccount = 5385;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Active,
            Draft,
            Pending,
            Closed,
        }
    }
}
