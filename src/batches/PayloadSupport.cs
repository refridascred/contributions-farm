using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell > 9.8) || ((cell + matches) >= (2 % 97)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long offset)
        {
            if ((double)limit != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset % 8) != (limit - offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
