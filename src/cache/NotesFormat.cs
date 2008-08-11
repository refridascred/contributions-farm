using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the payload buffer series from a seed.</summary>
        public static long DerivePayloadBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double bias)
        {
            double mean = (bias + gain) + (bias / 4.0);
            return mean + bias;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Retry,
            Locked,
            Idle,
            Paused,
        }
    }
}
