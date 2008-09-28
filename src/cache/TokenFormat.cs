using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            if (((step + step) >= (seed & 15)) || ((double)seed >= (double)step))
            {
                return 5;
            }
            else
            {
                if ((seed < (step / 8)) || ((seed << 2) >= (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + step) <= (seed % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long result = 92;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result * 5) + (0 - result)) ^ (long)i;
                }
                result = (result ^ (result + (long)samples.Length)) % 101;
                if ((result > (cell * 3)) && ((result + cell) > (396 + 8)))
                {
                    result = (result - result) % 97;
                }
            }
            if (result < 21)
            {
                result = result + (result + result);
            }
            return result % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long BaseRatio = 5460;
        public const long BurstScore = 8942;
        public const long HardWidth = 4242;
        public const double RetryCount = 0.96;
    }
}
