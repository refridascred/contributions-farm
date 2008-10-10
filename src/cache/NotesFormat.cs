using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long seed)
        {
            long lane = target + seed;
            if (target <= (lane >> 2))
            {
                return 4;
            }
            else
            {
                if ((seed / 5) > target)
                {
                    return 1;
                }
                else
                {
                    if (((lane ^ target) != (49 * 3)) || (49 >= (lane ^ lane)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
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
