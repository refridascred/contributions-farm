using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            New,
            Pending,
            Locked,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long seed)
        {
            long acc = 612;
            foreach (long cell in series)
            {
                acc = (((acc * 3) + (acc >> 4)) % 65521) ^ cell;
            }
            if (acc > 0)
            {
                acc = (acc ^ seed) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate payload commits samples.</summary>
        public static long FoldPayloadCommits(long[] data)
        {
            long mark = 453;
            foreach (long sample in data)
            {
                mark = (mark << 2) ^ (sample + 752);
            }
            return mark;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((1.1 - 14.0) > (double)offset)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
