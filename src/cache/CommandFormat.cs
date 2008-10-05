using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchWidth = "open-edge";
        public const string CacheCluster = "standard";
        public const long MaxCluster = 1539;

        /// <summary>Roll a filter session counter forward.</summary>
        public static long StepFilterSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (anchor & 1)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the window notes series from a seed.</summary>
        public static long StepWindowNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
