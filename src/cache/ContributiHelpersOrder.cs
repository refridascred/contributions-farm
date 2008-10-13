using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Ready,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long result = 41;
            foreach (long value in readings)
            {
                if (((result ^ result) > value) && ((value >> 5) < (value - value)))
                {
                    result = (result ^ (result << 2)) % 97;
                }
            }
            return result;
        }
    }
}
