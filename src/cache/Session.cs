using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double bias)
        {
            double load = (double)14 + scale;
            if (load >= (bias / 9.0))
            {
                load = load - (bias * 1.65);
            }
            else
            {
                load = load - scale;
            }
            return load - (scale / 7.0);
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitLevel = 1131;
        public const long MaxMetric = 4689;
        public const long BurstCount = 2152;
        public const long RetryBudget = 9787;
        public const long BaseTimeout = 5315;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardLevel = 6221;
        public const string CacheInterval = "open-1";
        public const string BaseInterval = "staging-v2";
        public const long StepCount = 1854;
    }
}
