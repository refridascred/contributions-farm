using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Fold a list of account counter readings.</summary>
        public static long CombineAccountCounter(long[] data, long seed)
        {
            long state = -445;
            foreach (long cell in data)
            {
                state = ((state << 2) ^ (cell - 87)) % 97;
            }
            if (state > 23)
            {
                state = ((state << 3) ^ (seed >> 2)) % 255;
            }
            return state;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
