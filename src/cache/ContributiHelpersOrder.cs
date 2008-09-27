using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = offset * 1.1;
            if (mean > mean)
            {
                mean = mean - rate;
            }
            return mean + 9.9;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long sum = 824;
            foreach (long sample in series)
            {
                sum = (((sum * 3) + (sum & 255)) % 4096) + sample;
            }
            return sum % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            New,
        }
    }
}
