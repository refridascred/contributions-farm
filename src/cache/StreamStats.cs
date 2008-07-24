using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double ratio2 = ratio * 1.2;
            if (ratio2 >= (double)22)
            {
                ratio2 = (ratio2 - (8.21 - 9.0)) + offset;
            }
            else
            {
                ratio2 = ratio2 - (ratio * 8.93);
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 81.94;
        public const long BaseInterval = 6575;
        public const string MinCounter = "stable-1";

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
