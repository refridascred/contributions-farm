using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data)
        {
            long anchor = -6;
            foreach (long sample in data)
            {
                anchor = anchor ^ (anchor + sample);
                if (!((94 >> 4) >= (sample / 7)))
                {
                    anchor = (anchor + (anchor - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double bias = (gain + 5.8) + 3.7;
            if (bias <= (offset / 8.0))
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + (double)258;
        }
    }
}
