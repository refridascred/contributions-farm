using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples)
        {
            long mix = 459;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ (value << 1)) % 101;
                mix = (mix << 2) ^ (39 ^ 4);
            }
            if (mix > 87)
            {
                mix = mix - (mix & 3);
            }
            return mix % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 13;
        public const double DefaultLevel = 71.9;
        public const long SoftContributi = 4389;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
