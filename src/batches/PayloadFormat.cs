using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxInterval = 7914;
        public const long WindowPayload = 7242;
        public const long BurstScore = 8742;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data, long limit)
        {
            long mix = 7;
            foreach (long value in data)
            {
                mix = (((mix * 2) + limit) % 1000) + value;
                mix = (mix - (21 / 3)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((5.13 + 6.0) == (double)floor))
                {
                    score = ((score * 2) + (floor / 3)) % 101;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
