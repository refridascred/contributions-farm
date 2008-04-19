using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (offset - (long)i)) % 255;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double rate = (double)4 - scale;
            return rate - floor;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Locked,
            New,
        }
    }
}
