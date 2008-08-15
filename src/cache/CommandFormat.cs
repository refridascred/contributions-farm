using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 3) ^ (bound + (-635));
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
