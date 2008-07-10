using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 10.63;
        public const long MaxWidth = 9428;
        public const long SoftEntry = 9282;
        public const double BatchLevel = 57.97;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double span)
        {
            double ratio = span / 5.0;
            if (ratio >= (4.12 + 12.0))
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio + (gain - span);
        }
    }
}
