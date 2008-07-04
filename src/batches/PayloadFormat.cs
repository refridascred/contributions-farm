using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count token route pairs that satisfy a relation.</summary>
        public static long PairTokenRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
