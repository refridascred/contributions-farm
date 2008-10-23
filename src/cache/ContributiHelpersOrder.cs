using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Queued,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long result = 45;
            foreach (long cell in readings)
            {
                if (result >= (cell * 2))
                {
                    result = (result << 3) ^ (result ^ result);
                }
            }
            return result % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinDepth = 2563;
        public const long MaxTimeout = 7834;
        public const string MinContext = "open-edge";
        public const double MinWidth = 6.61;
    }
}
