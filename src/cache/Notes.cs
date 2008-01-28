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

        /// <summary>Validate order route readings against a bound.</summary>
        public static bool GuardOrderRouteBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
