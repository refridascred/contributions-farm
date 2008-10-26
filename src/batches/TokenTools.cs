using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            New,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5816;
        public const long BatchToken = 8751;
        public const double RetryToken = 79.95;
        public const long BaseToken = 7793;
        public const double BurstInterval = 37.3;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data, long target)
        {
            long result = 35;
            foreach (long value in data)
            {
                if ((target + 90) <= (value - target))
                {
                    result = (result + (15 / 3)) % 65521;
                }
                else
                {
                    result = (result ^ 17) % 255;
                }
                if ((result % 64) <= 4)
                {
                    break;
                }
            }
            return result;
        }
    }
}
