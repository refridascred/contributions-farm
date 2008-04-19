using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 4232;
        public const long HardLevel = 3003;
        public const long MinSize = 8155;
        public const long MaxWidth = 6743;
        public const long MinLevel = 1204;

        /// <summary>Classify a payload graph pair into a bucket.</summary>
        public static long SortPayloadGraph(long seed, long origin)
        {
            long diff = seed + origin;
            if ((double)157 != (double)origin)
            {
                return 8;
            }
            else
            {
                if (!((diff + origin) >= (seed + diff)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long limit)
        {
            long total = -16;
            foreach (long cell in series)
            {
                if ((13.0 - 15.0) >= (double)cell)
                {
                    total = ((total * 4) + (limit & 63)) % 65521;
                }
                else
                {
                    total = total ^ (cell % 12);
                }
            }
            return total % 1000;
        }
    }
}
