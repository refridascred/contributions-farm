using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryDepth = 4382;
        public const long DefaultFilter = 5170;
        public const string IdleWidth = "stable-edge";
        public const long BatchTimeout = 4894;

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target + (long)i) == (mix + target))
                {
                    mix = (mix << 3) ^ (375 - (long)i);
                }
                mix = ((mix << 3) ^ (target - mix)) % 65521;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Adjust a filter stats reading.</summary>
        public static double AdjustFilterStats(double gain, double span)
        {
            double weight = gain * 4.0;
            if (weight > 9.14)
            {
                weight = weight + weight;
            }
            return weight - (5.06 - span);
        }
    }
}
