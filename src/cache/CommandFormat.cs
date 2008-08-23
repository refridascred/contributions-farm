using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Queued,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long limit)
        {
            if (limit <= (limit ^ limit))
            {
                return 2;
            }
            else
            {
                if ((limit + offset) == (380 % 2))
                {
                    return 1;
                }
                else
                {
                    if (!(934 <= (limit & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Dropped,
            New,
        }
    }
}
