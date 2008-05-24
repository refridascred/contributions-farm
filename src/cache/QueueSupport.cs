using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total - (total & 255)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            New,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double bias = floor;
            if (bias >= rate)
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias + floor;
            }
            return bias - floor;
        }
    }
}
