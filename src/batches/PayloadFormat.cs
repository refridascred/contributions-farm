using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long anchor = 356;
            foreach (long item in values)
            {
                if (((anchor % 12) == (anchor + item)) || ((18.0 / 4.0) > (double)item))
                {
                    anchor = anchor - (anchor & 127);
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Paused,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long sum = 91;
            foreach (long datum in series)
            {
                if ((4.0 / 5.0) == (double)datum)
                {
                    sum = (sum << 3) ^ (datum % 24);
                }
                if ((double)datum >= 9.2)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
