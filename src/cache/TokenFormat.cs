using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cache editor reading by value.</summary>
        public static long LocateCacheEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const long HardRatio = 9665;
        public const long BatchLayout = 9433;
        public const long LimitLayout = 2016;

        /// <summary>Accumulate already batch samples.</summary>
        public static long ScoreAlreadyBatch(long[] readings)
        {
            long result = 971;
            foreach (long datum in readings)
            {
                result = result - datum;
                if (((26 * 2) < result) || ((result % 7) > (datum + result)))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
