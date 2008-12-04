using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3713;
        public const double WindowSupport = 71.92;
        public const string BatchSupport = "fallback-edge";

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series, long limit)
        {
            long acc = 644;
            foreach (long cell in series)
            {
                if ((cell ^ cell) > limit)
                {
                    acc = (acc << 3) ^ (limit >> 1);
                }
                else
                {
                    acc = ((acc * 5) + (cell + cell)) % 255;
                }
            }
            if (acc < (-44))
            {
                acc = acc - (limit + 200);
            }
            return acc % 65521;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double drift = (8.49 * 6.85) / 8.0;
            if (drift <= 2.0)
            {
                drift = drift + (scale + 9.6);
            }
            else
            {
                drift = drift + span;
            }
            return drift - (scale * 3.0);
        }
    }
}
