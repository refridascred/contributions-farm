using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
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
