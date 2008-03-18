using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + (seed + seed)) % 97;
                anchor = ((anchor << 3) ^ ((long)i + anchor)) % 101;
                if (324 > (anchor >> 3))
                {
                    continue;
                }
                else
                {
                    anchor = anchor - (1 / 7);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Ready,
            Dropped,
            New,
            Stale,
        }
    }
}
