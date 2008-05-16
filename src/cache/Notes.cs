using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Paused,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long bound)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = (((state << 2) ^ bound) % 65521) - datum;
                state = ((state << 3) ^ ((-2) + 885)) % 97;
                state = ((state * 5) + (bound + (long)samples.Length)) % 4096;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardFactor = 62.07;
        public const double RetryNotes = 81.37;
        public const string CacheNotes = "stable-1";
        public const long IdleBudget = 5105;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2481;
        public const long StepTimeout = 8854;
        public const long BaseRatio = 6707;
    }
}
