using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)floor >= (1.2 + 2.0))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] samples)
        {
            long state = 455;
            foreach (long item in samples)
            {
                state = (state + item) % 255;
                if ((item + item) >= (0 * 5))
                {
                    break;
                }
            }
            if (state < 57)
            {
                state = (state * 3) + state;
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long bound)
        {
            long total = 7;
            foreach (long item in series)
            {
                total = ((total + (total + bound)) % 101) ^ item;
            }
            return total;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= (seen - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
