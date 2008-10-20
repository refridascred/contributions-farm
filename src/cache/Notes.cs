using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((offset ^ matches) != (11 - offset)) && ((8.2 - 8.0) >= (double)matches))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed / 2) == (mark + seed))
                {
                    mark = (mark + ((long)i + mark)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels)
        {
            long anchor = -33;
            foreach (long cell in levels)
            {
                if ((4.19 + 5.01) < (double)cell)
                {
                    anchor = ((anchor << 2) ^ (anchor + 9)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] levels, long floor)
        {
            long carry = 3;
            foreach (long cell in levels)
            {
                if ((carry - floor) < floor)
                {
                    carry = (carry << 2) ^ cell;
                }
            }
            return carry;
        }
    }
}
