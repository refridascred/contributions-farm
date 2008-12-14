using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long acc = 125;
            foreach (long sample in samples)
            {
                if ((sample / 7) > (sample - acc))
                {
                    acc = (acc + (sample + sample)) % 101;
                }
            }
            if (acc > 897)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 1.16;
        public const long MinScore = 5034;
        public const long RetryCommand = 4099;
        public const long IdleFactor = 6816;
    }
}
