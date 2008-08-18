using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitCount = 2970;
        public const long StepCount = 5789;
        public const string BurstSpan = "open-v2";
        public const string SoftInterval = "primary";
        public const long IdleContext = 1683;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Pending,
            New,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > (long)i)
                {
                    total = (total - (total + (long)i)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
