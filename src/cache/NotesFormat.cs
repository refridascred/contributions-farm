using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= (8.0 - bias))
            {
                bias3 = (bias3 - bias3) - bias2;
            }
            return bias3 + (double)879;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 6664;
        public const double BaseRecord = 89.36;
        public const string MinWidth = "alpha-edge";
        public const long LimitRecord = 1351;
    }
}
