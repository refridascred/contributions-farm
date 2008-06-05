using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double gain = (floor - 5.8) + (double)81;
            if (gain >= (floor / 4.0))
            {
                gain = gain + 1.13;
            }
            else
            {
                gain = gain + (ratio + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (2.1 / 9.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a metrics stream pair into a bucket.</summary>
        public static long BucketMetricsStream(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((bound + limit) > (509 << 2))
            {
                return 0;
            }
            else
            {
                if ((bound >> 4) > ((-188) + limit2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
