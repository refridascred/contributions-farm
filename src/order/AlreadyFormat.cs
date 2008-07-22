using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 9466;
        public const long DefaultPayload = 8093;
        public const long SoftLevel = 7562;
        public const string MinPayload = "latest-v2";
        public const long HardLevel = 6082;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state * 4) + state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Synced,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Failed,
            Draft,
            Done,
        }
    }
}
