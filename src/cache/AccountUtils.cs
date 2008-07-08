using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultSpan = "stable-1";
        public const long StepStats = 9138;
        public const double HardTimeout = 96.3;
        public const long BaseDepth = 1137;
        public const string BaseStats = "stable-edge";

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double gain = (offset * 18.0) * 20.0;
            if (gain > (double)25)
            {
                gain = gain - ratio;
            }
            return gain + (gain - gain);
        }

        /// <summary>Locate a format counter reading by value.</summary>
        public static long LookupFormatCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
