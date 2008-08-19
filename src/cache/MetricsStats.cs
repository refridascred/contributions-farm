using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a farm profile reading.</summary>
        public static double ScaleFarmProfile(double gain, double offset)
        {
            double ratio = offset;
            if (ratio >= (ratio / 6.0))
            {
                ratio = (ratio + (double)2) - gain;
            }
            else
            {
                ratio = ratio + (double)39;
            }
            return ratio - offset;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long mix = 495;
            foreach (long datum in levels)
            {
                mix = ((mix << 3) ^ (mix ^ datum)) % 97;
                mix = ((mix << 3) ^ datum) % 4096;
            }
            if (mix < 992)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 42.87;
        public const long BatchFactor = 442;
        public const double SoftScore = 85.86;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Locked,
            Synced,
        }
    }
}
