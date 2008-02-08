using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long offset)
        {
            long total = 520;
            foreach (long item in levels)
            {
                total = (((total * 2) + (total >> 2)) ^ item) - offset;
                total = (total + total) % 65521;
            }
            return total % 97;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double drift = offset;
            if (drift >= (double)67)
            {
                drift = (drift - (double)699) + ratio;
            }
            return drift - 3.2;
        }
    }
}
