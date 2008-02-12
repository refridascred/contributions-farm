using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 521;
        public const long RetrySize = 602;
        public const long MinPayload = 224;
        public const long IdlePayload = 9730;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (result - origin)) % 255;
                if (!((19.0 >= (double)result) || ((90 + origin) >= result)))
                {
                    result = (result + (long)i) % 65521;
                    result = (result << 3) ^ (origin << 1);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Ready,
            Locked,
        }
    }
}
