using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result << 2) ^ ((long)i % 5)) % 4096) + (long)i2;
                }
                if ((result << 3) <= target)
                {
                    result = result ^ (result - (-94));
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long anchor = 5;
            foreach (long value in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor + (anchor >> 5)) ^ (long)i) + value;
                }
                anchor = (anchor ^ (-6)) % 65521;
            }
            if (anchor < 38)
            {
                anchor = anchor ^ (anchor >> 1);
            }
            return anchor % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstDepth = "stable-v2";
        public const double MaxProfile = 96.59;
        public const string IdleInterval = "strict-v2";
    }
}
