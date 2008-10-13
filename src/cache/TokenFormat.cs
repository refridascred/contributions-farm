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

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
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
