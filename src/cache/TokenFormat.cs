using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitWidth = 2967;
        public const long RetryEditor = 8536;
        public const long IdleEditor = 3725;
        public const double CacheScore = 91.67;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ 346;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of payload command entries.</summary>
        public static long TallyPayloadCommand(long[] series)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                if (((461 + mark) != (mark % 3)) && (reading > (mark ^ reading)))
                {
                    mark = mark - (mark + reading);
                }
            }
            if (mark < 7)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark % 97;
        }
    }
}
