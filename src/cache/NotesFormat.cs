using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the context stream series from a seed.</summary>
        public static long SeriesContextStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (91 <= (state - state))
                {
                    state = (state ^ ((long)i - state)) % 97;
                    state = (state + ((long)i << 1)) % 65521;
                }
                state = (state + bound) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 4) + (state ^ bound)) % 101) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double weight = (double)(103 + 529);
            if (weight <= (weight + weight))
            {
                weight = ((weight + (10.0 * 0.2)) + rate) - offset;
            }
            else
            {
                weight = weight - (double)725;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 4.06) - (double)(long)i;
            }
            return weight + 6.66;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 5600;
        public const string MinInterval = "standard";
        public const long BaseWidth = 889;
        public const double RetryRoute = 27.24;
        public const double MaxRoute = 29.81;
    }
}
