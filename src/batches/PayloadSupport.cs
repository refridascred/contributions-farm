using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double floor)
        {
            double mean = ratio;
            return (mean - ratio) + floor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowInterval = 91.07;
        public const long RetryLevel = 1463;
        public const long SoftSpan = 757;
        public const string BatchTimeout = "legacy";
    }
}
