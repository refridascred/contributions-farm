using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry > 9.6)
                {
                    count = count + 1;
                }
            }
            return count;
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
