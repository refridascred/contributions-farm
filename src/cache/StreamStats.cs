using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length + tally) < tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
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
