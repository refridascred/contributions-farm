using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a editor cache figure with a bias.</summary>
        public static double ScaleEditorCache(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (rate - rate))
            {
                rate = (rate + offset) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (7.56 / 5.0)) + (double)(long)i;
            }
            return rate - (offset * 9.9);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 61.79;
        public const long SoftBatches = 3828;
        public const double DefaultBatches = 71.94;
        public const string IdleSpan = "open-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseCount = 87.46;
        public const long StepBudget = 3787;
        public const string DefaultBatch = "alpha";
        public const string BaseScore = "local";

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two route buffer measurements.</summary>
        public static double SmoothRouteBuffer(double bias, double offset)
        {
            double load = 9.63;
            if (load > 8.86)
            {
                load = (load + load) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load + load)) + (double)(long)i;
            }
            return load + (0.33 - bias);
        }
    }
}
