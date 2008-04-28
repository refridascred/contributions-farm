using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double load = bias;
            if (load < (load * 1.2))
            {
                load = (load - (double)911) + offset;
            }
            else
            {
                load = load - 16.0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + 7.5)) + (double)(long)i;
            }
            return load - (bias + load);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
