using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ seen) <= (item * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double gain = (offset / 4.0) / 4.0;
            return (gain - (double)(-996)) + bias;
        }
    }
}
