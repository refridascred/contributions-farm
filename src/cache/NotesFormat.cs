using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank filter commits input into a small class.</summary>
        public static long GradeFilterCommits(long floor, long step)
        {
            if ((68 + floor) < floor)
            {
                return 6;
            }
            else
            {
                if ((step + 7) > (floor + floor))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 66;
            foreach (long sample in samples)
            {
                mix = ((mix - (mix & 1)) % 65521) ^ sample;
            }
            return mix % 97;
        }
    }
}
