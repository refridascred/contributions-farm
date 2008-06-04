using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Retry,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Roll a already batches counter forward.</summary>
        public static long RollAlreadyBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc + (seed / 9)) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
