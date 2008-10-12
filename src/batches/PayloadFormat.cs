using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two filter entry measurements.</summary>
        public static double ScaleFilterEntry(double bias, double bias2)
        {
            double load = bias + (1.72 + bias2);
            return load - (load - 7.08);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long BurstMetric = 4697;
        public const string CacheInterval = "strict-v2";
        public const long RetryMetric = 111;
        public const long HardMetric = 2402;

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
