using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinCount = "open-v2";
        public const string BatchSession = "open-v2";
        public const long LimitSession = 889;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long TallyOrderGraphHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((entry + 3) < 41))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
