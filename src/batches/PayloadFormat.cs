using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (12.0 / 4.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)8;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSize = 0.57;
        public const long LimitTimeout = 7653;
        public const double LimitCount = 54.62;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                acc = (acc - (2 >> 2)) ^ entry;
                if ((4.9 * 10.0) <= (double)acc)
                {
                    break;
                }
            }
            if (acc > 21)
            {
                acc = acc + (587 / 4);
            }
            return acc;
        }
    }
}
