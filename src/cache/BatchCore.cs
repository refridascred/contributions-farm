using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 22.11;
        public const long RetryInterval = 2753;
        public const string BurstLevel = "latest-edge";
        public const double CacheFarm = 23.7;

        /// <summary>Count the tools entry entries that pass the check.</summary>
        public static long CountToolsEntryHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (offset < (offset - offset))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Idle,
            Stale,
            Failed,
            Done,
        }
    }
}
