using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Done,
            Closed,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] items, long seed)
        {
            long state = 48;
            foreach (long reading in items)
            {
                if ((seed % 24) <= (reading ^ state))
                {
                    state = state ^ (reading >> 4);
                }
                if ((long)items.Length >= (-9))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
