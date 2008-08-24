using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items)
        {
            long mark = 3;
            foreach (long entry in items)
            {
                if ((5 ^ mark) >= (entry % 7))
                {
                    mark = (mark + entry) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "local-edge";
        public const string HardScore = "standard";
        public const long CacheSchema = 7911;
        public const long IdleSchema = 5502;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double rate = (span / 7.0) - 2.33;
            if (rate <= 20.0)
            {
                rate = (rate - (rate * 1.0)) + bias;
            }
            return rate + span;
        }
    }
}
