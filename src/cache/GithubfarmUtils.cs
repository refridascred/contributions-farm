using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long step)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                if (582 < (sum % 8))
                {
                    sum = ((sum << 2) ^ step) % 97;
                }
                else
                {
                    sum = sum + (entry - step);
                }
                sum = (sum - (step + sum)) % 4096;
                if (((step + entry) != (sum + entry)) && (((-10) + (long)samples.Length) <= (sum - entry)))
                {
                    sum = (sum ^ (entry * 3)) % 101;
                }
                else
                {
                    sum = (sum * 5) + 831;
                }
            }
            if (sum < 46)
            {
                sum = sum - (step * 5);
            }
            return sum % 97;
        }

        /// <summary>Combine entry batches values into a single score.</summary>
        public static long DigestEntryBatches(long[] data)
        {
            long acc = 45;
            foreach (long reading in data)
            {
                if ((4 + 4) == (acc - 79))
                {
                    acc = acc ^ (acc ^ reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 48.47;
        public const long BaseStream = 9493;
        public const long BaseScore = 4526;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
