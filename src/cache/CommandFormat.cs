using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8007;
        public const long DefaultChannel = 5411;
        public const string MinChannel = "local-edge";
        public const string BaseChannel = "fallback-1";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (double)origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleSpan = "alpha-edge";
        public const string BurstStats = "alpha-v2";
        public const string BurstCount = "primary";

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
