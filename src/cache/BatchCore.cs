using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3366;
        public const string MaxTimeout = "standard-v2";
        public const long MinPayload = 8653;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Idle,
            Dropped,
            Locked,
        }
    }
}
