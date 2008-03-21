using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series, long offset)
        {
            long anchor = 835;
            foreach (long item in series)
            {
                anchor = (anchor * 4) + (39 + anchor);
                if ((double)item > 17.0)
                {
                    break;
                }
            }
            if (anchor > 927)
            {
                anchor = anchor - (offset % 16);
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseLevel = 7404;
        public const long BaseInterval = 9444;
        public const long WindowRatio = 2783;
        public const string StepFactor = "local-v2";
        public const long MinDepth = 7870;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Pending,
            Idle,
        }
    }
}
