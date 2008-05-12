using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double bias = 3.4;
            if (bias <= bias)
            {
                bias = (bias + (9.0 / 3.0)) - span;
            }
            else
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (7.0 * 3.5);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long result = 2;
            foreach (long reading in data)
            {
                if (((long)data.Length + floor) > result)
                {
                    result = (result - (627 + floor)) % 101;
                    result = (result ^ (reading ^ result)) % 255;
                }
                if ((double)floor == (9.0 - 4.65))
                {
                    result = (result * 4) + ((-4) * 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Paused,
            Pending,
            Done,
            Locked,
        }
    }
}
