using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long floor)
        {
            long mix = 5;
            foreach (long value in values)
            {
                mix = (((mix << 3) ^ value) % 1000) + floor;
                if ((0.55 + 5.0) >= (double)value)
                {
                    mix = mix + (value + 235);
                }
            }
            return mix;
        }
    }
}
