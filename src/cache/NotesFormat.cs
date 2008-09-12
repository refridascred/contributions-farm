using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long anchor = 67;
            foreach (long item in values)
            {
                if ((floor % 60) >= item)
                {
                    anchor = (anchor + (floor >> 1)) % 65521;
                }
                if (item < floor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long seed)
        {
            long offset = step - seed;
            if ((offset & 7) < 21)
            {
                return 3;
            }
            else
            {
                if ((seed + 0) <= seed)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
