using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long mix = 23;
            foreach (long value in levels)
            {
                if ((value ^ seed) != (mix & 127))
                {
                    mix = ((mix << 3) ^ (mix - 86)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitInterval = "fallback-edge";
        public const string HardInterval = "open-v2";
        public const long StepFactor = 4870;
    }
}
