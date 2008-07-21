using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long mark = 3;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (value & 7)) % 97;
                if (((value & 31) != ((-59) * 3)) || ((47 - mark) > mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
