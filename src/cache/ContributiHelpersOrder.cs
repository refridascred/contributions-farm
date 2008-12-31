using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long mark = 2;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ 366) % 255) + value;
                if (mark >= (314 * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
