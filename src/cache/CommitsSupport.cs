using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (-576)) <= (long)data.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 7409;
        public const double LimitNotes = 53.2;
        public const double BaseNotes = 11.42;
        public const long HardFactor = 1044;

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitWidth = 56.5;
        public const long LimitCount = 5533;
        public const string StepRecord = "strict-v2";

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((bound % 7) < prev)
            {
                return 3;
            }
            else
            {
                if (((16.0 - 1.1) != (double)bound) || ((double)bound != (3.3 / 2.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first session route entry that matches the target.</summary>
        public static long LocateSessionRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
