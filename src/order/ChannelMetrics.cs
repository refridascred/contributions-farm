using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long offset)
        {
            long mix = 134;
            foreach (long sample in samples)
            {
                if ((double)sample >= (19.0 / 3.0))
                {
                    mix = (mix + mix) % 4096;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            if (mix < (-6))
            {
                mix = (mix * 4) + (offset + mix);
            }
            return mix;
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
