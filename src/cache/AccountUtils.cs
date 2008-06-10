using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double drift = floor + floor;
            if (drift < weight)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - (drift + 8.0);
            }
            return drift - (double)(-3);
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
