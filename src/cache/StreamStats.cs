using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values)
        {
            long score = 10;
            foreach (long value in values)
            {
                if (((8.76 / 4.0) != (double)value) && ((double)5 < (double)value))
                {
                    score = ((score * 5) + (score >> 1)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleSize = "open-edge";
        public const long MinSize = 5920;
        public const string DefaultDepth = "alpha-v2";
        public const long IdleSpan = 7316;
        public const long BurstFactor = 3067;

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Paused,
            Retry,
        }
    }
}
