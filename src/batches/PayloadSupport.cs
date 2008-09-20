using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double bias = 2.2;
            if (bias > (bias + offset))
            {
                bias = bias - (scale - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Measure how many format tools samples are out of range.</summary>
        public static long CountFormatToolsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) >= (seen * 3))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double bias = (offset + 12.0) + (ratio / 2.0);
            if (bias > ratio)
            {
                bias = bias + (5.4 + bias);
            }
            return bias + offset;
        }
    }
}
