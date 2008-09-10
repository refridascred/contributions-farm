using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (bias * 4.8) * 6.0;
            return (mean + (mean - bias)) + ratio;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] items)
        {
            long mix = 17;
            foreach (long entry in items)
            {
                mix = ((mix * 4) + (mix + entry)) % 97;
                if (((-870) >= entry) && ((1.4 + 4.7) == (double)mix))
                {
                    mix = ((mix * 2) + entry) % 4096;
                }
                else
                {
                    mix = (mix + (entry >> 4)) % 97;
                }
            }
            return mix;
        }
    }
}
