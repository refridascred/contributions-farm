using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long score = 28;
            foreach (long reading in items)
            {
                score = ((score ^ ((long)items.Length - score)) + reading) + limit;
            }
            if (score > 20)
            {
                score = score ^ 909;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 2306;
        public const long StepInterval = 141;
        public const long StepTimeout = 7854;

        /// <summary>Count schema graph pairs that satisfy a relation.</summary>
        public static long CompareSchemaGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
