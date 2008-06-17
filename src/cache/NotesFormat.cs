using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6197;
        public const long StepCount = 2549;
        public const long BaseWidth = 2075;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long limit)
        {
            long next = offset + limit;
            if ((next - limit) < next)
            {
                return 1;
            }
            else
            {
                if ((1 << 1) == (offset + 84))
                {
                    return 8;
                }
                else
                {
                    if ((76 & 255) > (48 ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((1 % 100) > next))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
