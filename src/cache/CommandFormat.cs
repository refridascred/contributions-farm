using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double bias, double offset)
        {
            double scale = 1.6;
            if (scale < offset)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (17.0 / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 4.0)) + (double)(long)i;
            }
            return scale - (scale * 7.6);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheFactor = 63.35;
        public const string IdleGraph = "primary-v2";
        public const double SoftRatio = 74.05;
        public const double BatchGraph = 88.93;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
