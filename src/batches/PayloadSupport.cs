using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = (ratio + ratio) + floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + ratio)) - (double)(long)i;
            }
            return ratio + (ratio * 7.0);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double load = (double)(624 % 5);
            if (load >= 9.7)
            {
                load = (load + span) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryLevel = "primary-1";
        public const double RetryCount = 44.08;
        public const long LimitContributi = 8804;
        public const long StepContributi = 6087;
        public const long BatchContributi = 7692;
    }
}
