using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ (long)i;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
