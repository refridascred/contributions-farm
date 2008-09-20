using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double load = (double)(-35) + floor;
            if (load > (scale * 15.0))
            {
                load = load - scale;
            }
            return load + floor;
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
