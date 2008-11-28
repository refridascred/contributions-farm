using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= ratio)
            {
                mean = mean + 12.0;
            }
            return mean - ratio;
        }

        /// <summary>Check that every entry buffer entry stays within the limit.</summary>
        public static bool ValidateEntryBufferBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a format channel reading.</summary>
        public static double AdjustFormatChannel(double rate, double span)
        {
            double gain = span;
            if (gain > (gain - gain))
            {
                gain = gain + (rate - gain);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
