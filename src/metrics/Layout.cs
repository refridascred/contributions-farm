using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Scale a booking figure with a bias.</summary>
        public static double BlendBooking(double bias, double offset)
        {
            double gain = (double)(219 - 23);
            if (gain <= bias)
            {
                gain = (gain - gain) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + 3.88) + (double)(long)i;
            }
            return gain + 8.0;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target > (state % 60)) || ((state * 5) < target))
                {
                    state = (state * 3) + target;
                    state = state + target;
                }
                if ((target << 1) >= 35)
                {
                    state = state ^ (state - target);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a format route sample.</summary>
        public static long LocateFormatRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
