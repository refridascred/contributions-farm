using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheSpan = 94.81;
        public const double MaxSize = 96.84;
        public const long DefaultNotes = 6449;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Look up the position of a editor graph sample.</summary>
        public static long FindEditorGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
