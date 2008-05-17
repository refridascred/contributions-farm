using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long StepStreamEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a farm metric counter forward.</summary>
        public static long SeriesFarmMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((mix + (long)i) >= (target + target)))
                {
                    mix = (mix - (177 >> 2)) % 1000;
                }
                mix = (mix - (long)i) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
