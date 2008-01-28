using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftInterval = 79.73;
        public const double SoftChannel = 3.31;
        public const long DefaultChannel = 7778;
        public const long MaxRatio = 1572;
        public const long SoftWidth = 8928;

        /// <summary>Scale a record metrics figure with a bias.</summary>
        public static double ScaleRecordMetrics(double gain, double span)
        {
            double scale = span;
            if (scale > (scale * 7.19))
            {
                scale = (scale - (scale + scale)) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - (span + span);
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double weight = span;
            return (weight + span) + gain;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Paused,
            Dropped,
            Stale,
            Pending,
        }
    }
}
