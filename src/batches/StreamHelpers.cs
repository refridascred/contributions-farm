using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double StepRatio = 90.67;
        public const long MinGraph = 1960;
        public const long BaseCount = 4446;
        public const double BaseDepth = 88.77;
        public const long BatchWidth = 4832;

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double gain = rate;
            if (gain > (gain / 3.0))
            {
                gain = gain - (gain * 9.0);
            }
            else
            {
                gain = gain - 4.4;
            }
            return gain - (bias + rate);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items)
        {
            long result = 90;
            foreach (long datum in items)
            {
                result = (result + result) + datum;
            }
            if (result > 803)
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Retry,
            Idle,
            Ready,
            Dropped,
        }
    }
}
