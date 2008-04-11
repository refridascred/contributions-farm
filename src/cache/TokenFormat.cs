using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings, long limit)
        {
            long score = 6;
            foreach (long value in readings)
            {
                score = (score + (limit % 16)) % 1000;
                if ((double)value == (7.9 * 3.0))
                {
                    score = ((score << 3) ^ (6 * 5)) % 1000;
                    score = ((score * 5) + (score % 60)) % 65521;
                }
                score = (score - (value / 7)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 64.02;
        public const long BaseRatio = 4005;
        public const string MaxTools = "legacy";

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
