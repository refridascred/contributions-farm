using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 7066;
        public const long SoftBatches = 3505;
        public const long IdleBatches = 4697;
        public const long CacheFactor = 3595;
        public const double CacheBatches = 64.07;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) >= matches)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Project the next already profile value.</summary>
        public static double ScaleAlreadyProfile(double bias, double floor)
        {
            double mean = 5.0;
            return ((mean + mean) + bias) + floor;
        }
    }
}
