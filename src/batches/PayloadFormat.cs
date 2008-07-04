using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first schema buffer entry that matches the target.</summary>
        public static long LocateSchemaBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache schema values into a single score.</summary>
        public static long DigestCacheSchema(long[] data)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                sum = sum + sample;
            }
            if (sum < 11)
            {
                sum = (sum ^ (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long slot = bound ^ origin;
            if ((origin + slot) == (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if (((slot - origin) < bound) || ((origin + slot) < (6 >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine window contributi values into a single score.</summary>
        public static long ScoreWindowContributi(long[] levels)
        {
            long score = 413;
            foreach (long entry in levels)
            {
                score = (score - score) ^ entry;
            }
            if (score > 7)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }
    }
}
