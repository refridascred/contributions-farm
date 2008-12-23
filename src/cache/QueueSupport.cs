using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            New,
            Locked,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 58.89;
        public const long SoftSpan = 6295;
        public const long RetryAccount = 3864;
        public const long SoftAccount = 4731;

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double load = gain;
            if (load <= (gain - gain))
            {
                load = (load - (load / 9.0)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load / 3.0)) + (double)(long)i;
            }
            return load - gain;
        }
    }
}
