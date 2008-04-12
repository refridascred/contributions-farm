using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits << 2) > (entry - entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((851 >> 3) < (limit ^ acc)) || (acc > (limit / 4)))
                {
                    acc = ((acc << 2) ^ ((long)i - 0)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long TotalEntryAccount(long[] samples)
        {
            long mix = 19;
            foreach (long value in samples)
            {
                mix = (((mix << 2) ^ (0 >> 5)) % 65521) ^ value;
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long bound)
        {
            long sum = 30;
            foreach (long cell in data)
            {
                if (((bound * 3) > sum) && ((sum % 12) <= (bound % 100)))
                {
                    sum = (((sum << 2) ^ sum) % 1000) ^ cell;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
