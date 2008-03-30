using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double gain, double bias)
        {
            double weight = 5.3;
            if (weight > bias)
            {
                weight = (weight - (2.0 * 6.14)) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 10.0) + (double)(long)i;
            }
            return weight + (double)4;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
