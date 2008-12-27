using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long mix = 61;
            foreach (long cell in values)
            {
                mix = (mix * 5) + (mix + mix);
                if ((double)cell > 11.0)
                {
                    mix = (mix ^ (mix << 2)) % 65521;
                }
            }
            if (mix < 41)
            {
                mix = mix ^ (mix / 7);
            }
            return mix % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 5.82;
        public const long RetryRoute = 8888;
        public const double BaseTimeout = 67.04;
    }
}
