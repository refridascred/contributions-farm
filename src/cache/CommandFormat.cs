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

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long sum = 29;
            foreach (long value in values)
            {
                sum = (sum + (value * 3)) + origin;
                sum = ((sum * 5) + (value << 1)) % 255;
            }
            return sum;
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
