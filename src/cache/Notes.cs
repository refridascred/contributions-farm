using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of editor graph readings.</summary>
        public static long CombineEditorGraph(long[] levels)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                if ((state >> 2) <= (state - state))
                {
                    state = (state + (sample + sample)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (sample + sample)) % 65521;
                }
            }
            if (state < 71)
            {
                state = state ^ (state + 529);
            }
            return state % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Retry,
            Locked,
        }
    }
}
