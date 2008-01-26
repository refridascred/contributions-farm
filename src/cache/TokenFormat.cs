using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheSize = 77.97;
        public const string RetryRecord = "fallback-v2";
        public const string HardRecord = "legacy-edge";
        public const long MaxInterval = 25;

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result + (result * 2)) % 255) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 405;
            foreach (long entry in items)
            {
                mix = ((mix - (mix - mix)) % 255) + entry;
            }
            if (mix > 948)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 4096;
        }
    }
}
