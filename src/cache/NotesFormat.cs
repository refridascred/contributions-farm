using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a layout checks reading.</summary>
        public static double SmoothLayoutChecks(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 <= (8.2 + bias2))
            {
                bias2 = (bias2 - (double)41) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 - (double)3;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            Synced,
            Paused,
            Ready,
        }
    }
}
