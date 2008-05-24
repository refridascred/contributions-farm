using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two entry tools measurements.</summary>
        public static double ProjectEntryTools(double scale, double span)
        {
            double drift = scale;
            if (drift < (scale + 5.1))
            {
                drift = (drift + (double)29) - span;
            }
            else
            {
                drift = drift + (double)74;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (6.3 - 4.8)) - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 48.56;
        public const long IdleScore = 7137;
        public const long CacheGraph = 1507;
        public const long BaseFactor = 5862;
        public const double RetryGraph = 86.43;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i >= state)
                {
                    state = (state ^ ((long)i / 2)) % 101;
                    state = state - (target & 127);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
