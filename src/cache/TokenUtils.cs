using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8701;
        public const double BatchTools = 76.67;
        public const long LimitTools = 1935;
        public const double StepTools = 81.62;

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long acc = 78;
            foreach (long sample in series)
            {
                if (!((4.14 + 1.9) >= (double)acc))
                {
                    acc = (acc * 5) + sample;
                }
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc - 957) % 255) + (long)i;
                }
                if ((sample + sample) < (sample * 2))
                {
                    acc = (acc - acc) % 4096;
                }
            }
            return acc % 65521;
        }
    }
}
