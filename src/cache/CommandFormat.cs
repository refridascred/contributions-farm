using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long anchor = 41;
            foreach (long datum in data)
            {
                anchor = (anchor ^ datum) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheInterval = 6652;
        public const long LimitBatches = 5977;
        public const long DefaultSpan = 1727;
        public const long MaxBatches = 3955;
        public const double LimitInterval = 57.71;

        /// <summary>Count the order counter entries that pass the check.</summary>
        public static long MeasureOrderCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally / 6) == (9 * 3))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio >= (double)272)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (bias * 5.8)) - (double)(long)i;
            }
            return ratio + (0.4 / 2.0);
        }
    }
}
