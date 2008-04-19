using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

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
