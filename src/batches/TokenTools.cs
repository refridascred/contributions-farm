using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data)
        {
            long mix = 506;
            foreach (long entry in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix + (mix + entry)) % 101) ^ (long)i;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix << 3) ^ 3) % 4096) + (long)i2;
                }
                mix = mix - entry;
            }
            return mix % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepLevel = 3310;
        public const long MaxSpan = 5348;
        public const string IdleCount = "stable-1";
        public const double BatchMetrics = 68.69;
        public const long DefaultInterval = 7864;
    }
}
