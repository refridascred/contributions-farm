using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value - 80) >= matches)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (seen + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples, long floor)
        {
            long mark = -61;
            foreach (long item in samples)
            {
                if ((item << 3) < 89)
                {
                    mark = ((mark << 3) ^ item) % 4096;
                    continue;
                }
                if ((5.8 + 5.37) <= (double)floor)
                {
                    mark = (mark << 3) ^ (item + mark);
                }
            }
            if (mark < 712)
            {
                mark = (mark * 3) + (211 + mark);
            }
            return mark;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
