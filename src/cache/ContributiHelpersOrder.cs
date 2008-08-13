using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of window cluster readings.</summary>
        public static long TotalWindowCluster(long[] readings, long step)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                carry = carry ^ step;
                if ((cell % 3) <= ((-59) & 255))
                {
                    carry = ((carry << 2) ^ ((long)readings.Length % 8)) % 4096;
                    carry = carry ^ cell;
                }
                if ((cell & 127) < step)
                {
                    carry = ((carry * 4) + (carry - step)) % 97;
                }
            }
            if (carry < 335)
            {
                carry = (carry ^ step) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 1939;
        public const string BaseRatio = "staging-1";
        public const double DefaultTimeout = 83.8;
        public const string IdleChannel = "open-v2";

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
