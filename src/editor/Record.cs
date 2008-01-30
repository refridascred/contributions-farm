using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 7557;
        public const long RetryLevel = 5970;
        public const long LimitBudget = 5445;
        public const long RetryProfile = 9620;
        public const double HardLevel = 40.13;

        /// <summary>Audit graph editor readings against a rule.</summary>
        public static long CountGraphEditorMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading - origin) >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two booking measurements.</summary>
        public static double ScaleBooking(double gain, double bias)
        {
            double scale = (double)(93 + (-37));
            if (scale >= 7.75)
            {
                scale = (scale + scale) - gain;
            }
            return scale - bias;
        }
    }
}
