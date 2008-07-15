using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of profile counter readings.</summary>
        public static long DigestProfileCounter(long[] samples, long limit)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                if ((45 & 3) >= limit)
                {
                    mark = (mark - (limit * 3)) + item;
                }
            }
            return mark;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((bound % 7) >= (5 * 3))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
