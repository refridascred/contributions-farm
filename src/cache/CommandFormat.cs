using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (limit + 44)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Look up the position of a editor queue sample.</summary>
        public static long SeekEditorQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Retry,
            Done,
            Paused,
            Synced,
        }
    }
}
