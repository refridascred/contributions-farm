using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a notes window figure with a bias.</summary>
        public static double SmoothNotesWindow(double gain, double offset)
        {
            double ratio = gain + (gain * 7.56);
            if (ratio > (double)(-965))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (offset / 5.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long carry = 91;
            foreach (long datum in samples)
            {
                carry = carry ^ datum;
                if (((long)samples.Length > (carry - target)) && ((7 - datum) <= 451))
                {
                    carry = carry + (datum ^ carry);
                }
                else
                {
                    carry = carry - (target + datum);
                }
            }
            if (carry > 83)
            {
                carry = (carry ^ (9 << 3)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7933;
        public const long StepCluster = 4670;
        public const string MaxCluster = "local-edge";
        public const long DefaultRatio = 7909;
        public const long BaseFactor = 6115;
    }
}
