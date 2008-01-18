using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the notes channel series from a seed.</summary>
        public static long DeriveNotesChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepLevel = 70.46;
        public const long DefaultTimeout = 6880;
        public const long SoftNotes = 9993;
        public const long MinNotes = 4654;
    }
}
