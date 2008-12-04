using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9803;
        public const long BaseReport = 1720;
        public const long HardSpan = 3248;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double scale = 1.9;
            if (scale <= scale)
            {
                scale = (scale - 5.4) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale + (scale - ratio);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Queued,
            Done,
            Retry,
        }
    }
}
