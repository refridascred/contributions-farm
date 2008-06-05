using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the context support entries that pass the check.</summary>
        public static long AuditContextSupportHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally < (datum & 255))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Active,
            Failed,
            New,
        }

        /// <summary>Scale a notes stream figure with a bias.</summary>
        public static double AdjustNotesStream(double ratio, double floor)
        {
            double rate = (double)7 * 4.0;
            return (rate - ratio) + floor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9249;
        public const string BaseChannel = "latest";
        public const long MaxChannel = 132;
        public const double MinChannel = 56.86;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
