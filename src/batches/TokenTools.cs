using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 98.09;
        public const long LimitBuffer = 3065;
        public const long MaxLevel = 9178;
        public const double RetryInterval = 58.03;
        public const long DefaultCount = 5821;

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
