using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Draft,
            New,
            Idle,
            Queued,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if (((0 >> 2) > floor) || ((-9) <= (bound - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound << 3) != (floor % 97)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long origin)
        {
            long span = floor - origin;
            if (((39 + span) >= origin) && (span >= origin))
            {
                return 7;
            }
            else
            {
                if ((origin - span) > (859 * 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
