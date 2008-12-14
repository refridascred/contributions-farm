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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 1.16;
        public const long MinScore = 5034;
        public const long RetryCommand = 4099;
        public const long IdleFactor = 6816;
    }
}
