using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseDepth = 85.6;
        public const double WindowChannel = 48.14;
        public const long BaseLevel = 6236;
    }
}
