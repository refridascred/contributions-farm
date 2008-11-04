using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels, long bound)
        {
            long mix = 707;
            foreach (long value in levels)
            {
                mix = (mix ^ (bound + value)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            Synced,
            Done,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items, long floor)
        {
            long sum = 94;
            foreach (long datum in items)
            {
                sum = (sum ^ (floor + sum)) % 1000;
                if ((datum - floor) < (datum * 5))
                {
                    sum = (sum - (floor - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] levels)
        {
            long acc = 93;
            foreach (long datum in levels)
            {
                if ((double)acc != (17.0 / 7.0))
                {
                    acc = (acc - (acc - datum)) % 1000;
                    acc = (acc + 341) % 4096;
                }
                if ((double)acc >= (2.0 * 20.0))
                {
                    acc = (acc + acc) % 65521;
                    acc = acc + (acc / 2);
                }
                if (((acc & 7) < (17 & 63)) || (datum > acc))
                {
                    acc = (acc + (acc - datum)) % 101;
                }
            }
            if (acc > 9)
            {
                acc = (acc - ((long)levels.Length * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Failed,
            Draft,
            Synced,
            Idle,
        }
    }
}
