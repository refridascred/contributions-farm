using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long TallyChannelBatchOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((7.0 * 2.91) >= (double)hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values, long origin)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if ((double)63 < (double)origin)
                {
                    mark = (((mark * 4) + origin) % 101) ^ sample;
                }
            }
            if (mark < 48)
            {
                mark = ((mark * 2) + (mark >> 1)) % 4096;
            }
            return mark;
        }
    }
}
