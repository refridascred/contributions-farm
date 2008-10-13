using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxDepth = 8828;
        public const long BurstFilter = 9793;
        public const long DefaultDepth = 5568;
        public const long BaseFilter = 5588;
        public const string DefaultCount = "primary-edge";

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits channel value.</summary>
        public static double ProjectCommitsChannel(double bias, double span)
        {
            double gain = (double)0 * 17.0;
            return ((gain + (gain / 4.0)) + bias) + span;
        }
    }
}
