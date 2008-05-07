using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftSize = 88.74;
        public const long HardQueue = 7766;
        public const long IdleInterval = 5785;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Ready,
            Stale,
            New,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double rate = scale;
            if (rate <= (scale * 4.0))
            {
                rate = rate - (bias - rate);
            }
            else
            {
                rate = rate - (scale * 0.9);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + (scale * 6.0);
        }

        /// <summary>Locate a format filter reading by value.</summary>
        public static long LocateFormatFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
