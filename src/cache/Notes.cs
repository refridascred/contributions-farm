using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data, long limit)
        {
            long sum = 47;
            foreach (long item in data)
            {
                if ((item * 2) == ((-48) + (-5)))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                if ((3.5 - 9.84) <= (double)limit)
                {
                    break;
                }
            }
            if (sum > 628)
            {
                sum = ((sum * 4) + (-89)) % 97;
            }
            return sum;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((79 - matches) == (entry + matches))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
