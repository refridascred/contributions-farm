using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - tally) > (offset * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark * 4) + (floor - mark);
                mark = (mark + mark) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
