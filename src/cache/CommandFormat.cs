using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long seed)
        {
            long slot = offset + seed;
            if ((seed ^ offset) >= (offset >> 5))
            {
                return 7;
            }
            else
            {
                if ((slot / 9) < offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the notes metric series from a seed.</summary>
        public static long SeriesNotesMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (bound % 97)) % 4096;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Stale,
            Paused,
            Done,
            New,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }
    }
}
