using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxTimeout = 19.67;
        public const double CacheCount = 19.64;
        public const long BatchSupport = 8356;

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
