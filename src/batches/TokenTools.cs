using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if ((result % 7) < (cell - cell))
                {
                    result = ((result ^ ((-891) & 255)) % 255) + bound;
                }
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Paused,
            Pending,
            New,
        }
    }
}
