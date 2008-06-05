using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double bias = span + (ratio * 5.77);
            return bias - span;
        }

        /// <summary>Look up the position of a support checks sample.</summary>
        public static long LookupSupportChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Ready,
            New,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 6595;
        public const long StepSize = 1048;
        public const long DefaultFactor = 3743;
    }
}
