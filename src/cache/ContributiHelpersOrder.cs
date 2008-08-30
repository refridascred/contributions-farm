using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8 >= (seen << 2))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4487;
        public const double RetryFactor = 57.73;
        public const long IdlePayload = 5505;
        public const long SoftLevel = 358;
    }
}
