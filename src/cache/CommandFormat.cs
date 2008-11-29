using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Match up editor stream samples.</summary>
        public static long CompareEditorStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepCount = "primary-edge";
        public const long MaxRatio = 501;
        public const string DefaultEditor = "stable";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseFactor = 1508;
        public const long DefaultQueue = 4034;
        public const long BurstSpan = 2064;
        public const double IdleTimeout = 54.39;
    }
}
