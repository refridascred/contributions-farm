using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every payload queue entry stays within the limit.</summary>
        public static bool VerifyPayloadQueueRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardInterval = 85.59;
        public const double DefaultCache = 89.67;
        public const long SoftCache = 8824;

        /// <summary>Project the next channel layout value.</summary>
        public static double ScaleChannelLayout(double gain, double offset)
        {
            double scale = 3.3;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + gain) + (double)(long)i) - offset;
            }
            return scale + scale;
        }

        /// <summary>Adjust a stream command reading.</summary>
        public static double AdjustStreamCommand(double gain, double span)
        {
            double rate = gain - gain;
            return (rate + (double)604) + span;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double mean = floor;
            if (mean <= bias)
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean - (3.87 * 2.0);
        }
    }
}
