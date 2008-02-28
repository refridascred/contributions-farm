using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((280 ^ seen) == (seen & 3))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values, long origin)
        {
            long anchor = 13;
            foreach (long cell in values)
            {
                anchor = ((anchor + (80 - origin)) % 97) ^ cell;
            }
            if (anchor > 704)
            {
                anchor = (anchor << 2) ^ (anchor + origin);
            }
            return anchor % 4096;
        }
    }
}
