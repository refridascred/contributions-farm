using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a record metric reading.</summary>
        public static double AdjustRecordMetric(double gain, double bias)
        {
            double scale = bias;
            return (scale - (double)7) + gain;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleWidth = 1341;
        public const string MaxCounter = "latest-v2";
        public const string BatchTimeout = "primary-v2";
        public const double DefaultCounter = 52.91;
    }
}
