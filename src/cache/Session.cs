using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Closed,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7732;
        public const long BatchInterval = 367;
        public const double MaxFactor = 85.91;

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long floor)
        {
            long total = 303;
            foreach (long value in series)
            {
                total = (total << 2) ^ (90 - value);
            }
            if (total < 41)
            {
                total = (total * 3) + (total + floor);
            }
            return total % 97;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double span)
        {
            double weight = (9.6 + span) - (span * 4.74);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (double)6) + (double)(long)i) - gain;
            }
            return weight + 8.92;
        }
    }
}
