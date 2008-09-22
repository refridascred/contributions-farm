using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double gain = (double)(892 & 63);
            if (gain >= offset)
            {
                gain = (gain + (3.0 / 5.0)) - ratio;
            }
            else
            {
                gain = gain - (gain / 9.0);
            }
            return gain + offset;
        }
    }
}
