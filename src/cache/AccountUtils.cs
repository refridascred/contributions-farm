using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of window payload readings.</summary>
        public static long FoldWindowPayload(long[] levels)
        {
            long state = 1;
            foreach (long cell in levels)
            {
                if ((state / 2) >= (cell ^ (-77)))
                {
                    state = (state + (state - cell)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Idle,
            Synced,
        }
    }
}
