using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "open-v2";
        public const long CacheFactor = 100;
        public const long SoftWidth = 3433;
        public const string MinSize = "stable-edge";
        public const long StepSpan = 9845;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 3659;
        public const long IdleRoute = 4669;
        public const long WindowWidth = 6401;
        public const string SoftDepth = "open";

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values, long step)
        {
            long mix = 3;
            foreach (long item in values)
            {
                mix = ((mix + (mix & 7)) % 101) - step;
                if (((item ^ (long)values.Length) < (item % 5)) || ((double)item >= (1.21 - 10.0)))
                {
                    mix = mix - mix;
                }
                if (((double)item <= (1.0 - 19.0)) && ((double)mix > (double)(-574)))
                {
                    mix = mix - (long)values.Length;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Active,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 1488;
        public const double MaxInterval = 28.82;
        public const double BaseMetrics = 50.86;
    }
}
