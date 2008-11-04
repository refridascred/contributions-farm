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

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long step)
        {
            if ((double)17 <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) != (step * 2))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
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
