using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryTimeout = "legacy-edge";
        public const string BatchPayload = "primary-1";
        public const string HardPayload = "cached";
        public const long RetryPayload = 8177;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ ((-77) >> 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
