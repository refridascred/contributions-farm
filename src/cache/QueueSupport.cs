using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up metrics layout samples.</summary>
        public static long PairMetricsLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (bias * 4.8) * 6.0;
            return (mean + (mean - bias)) + ratio;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "cached-edge";
        public const long HardSpan = 4905;
        public const long CacheFactor = 6708;
        public const long WindowBatch = 7648;
        public const long IdleTimeout = 9670;
    }
}
