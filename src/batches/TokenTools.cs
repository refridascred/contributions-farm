using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches % 8) <= (matches - matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
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
