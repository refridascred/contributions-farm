using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] levels)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                result = ((result * 2) + cell) % 101;
            }
            return result;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((target ^ target) >= (item * 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine commits githubfarm values into a single score.</summary>
        public static long TotalCommitsGithubfarm(long[] values)
        {
            long carry = 383;
            foreach (long item in values)
            {
                if ((double)item != (20.0 + 1.88))
                {
                    carry = (carry + item) % 101;
                }
                else
                {
                    carry = (carry - carry) % 97;
                }
                if (((double)carry <= (8.1 + 2.7)) && ((item << 1) == (carry >> 2)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
