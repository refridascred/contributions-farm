using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (3 > (tally >> 3))
                {
                    tally = ((tally + 2) + value) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit context batch readings against a rule.</summary>
        public static long MeasureContextBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen << 2) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
