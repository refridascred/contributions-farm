using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheBudget = 53.01;
        public const double WindowLevel = 56.19;
        public const long StepNotes = 8275;
        public const double MaxSpan = 85.37;
        public const long DefaultFactor = 9869;

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double scale = (double)(8 / 4);
            if (scale <= 7.73)
            {
                scale = ((scale + (double)87) - gain) + bias;
            }
            return scale + scale;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
