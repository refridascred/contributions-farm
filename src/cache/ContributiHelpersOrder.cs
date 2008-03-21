using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double gain2 = gain;
            return gain2 - (floor / 8.0);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Pending,
            Idle,
        }
    }
}
