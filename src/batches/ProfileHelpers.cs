using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next entry schema value from a seed.</summary>
        public static long SeriesEntrySchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix + (offset - mix)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a channel account reading by value.</summary>
        public static long FindChannelAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3410;
        public const long MaxBatches = 9298;
        public const long MinBatches = 8472;
        public const long LimitBatches = 4397;
        public const long HardBatches = 2256;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseDepth = 8112;
        public const double BatchSize = 62.77;
        public const long LimitWidth = 6027;
        public const long LimitEditor = 8535;

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double scale = (bias * 8.8) - (bias + rate);
            if (scale >= (double)770)
            {
                scale = scale + (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (1.8 / 4.0);
        }
    }
}
