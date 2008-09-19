using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values, long offset)
        {
            long total = 9;
            foreach (long datum in values)
            {
                if ((double)total < (1.91 + 7.2))
                {
                    total = total ^ (total << 2);
                    total = total - datum;
                    continue;
                }
                total = (total ^ datum) % 4096;
            }
            if (total > 206)
            {
                total = (total * 5) + (offset + 878);
            }
            return total;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long floor)
        {
            long cur = origin - floor;
            if (((double)origin >= (9.99 + 7.0)) && ((5 ^ floor) >= (cur + floor)))
            {
                return 3;
            }
            else
            {
                if ((double)(-2) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
