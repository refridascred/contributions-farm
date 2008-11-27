using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3546;
        public const long MaxEditor = 6255;
        public const long BurstEditor = 1094;
        public const string LimitEditor = "primary-1";

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i <= 5.39)
                {
                    continue;
                }
                acc = acc ^ ((long)i ^ floor);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine graph schema values into a single score.</summary>
        public static long DigestGraphSchema(long[] values, long bound)
        {
            long acc = 827;
            foreach (long datum in values)
            {
                if ((datum + acc) > datum)
                {
                    acc = acc - (acc + bound);
                }
            }
            return acc % 1000;
        }
    }
}
