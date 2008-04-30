using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long target)
        {
            if (target < (63 / 9))
            {
                return 6;
            }
            else
            {
                if (!((target - target) <= (origin / 4)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a payload buffer counter forward.</summary>
        public static long SeriesPayloadBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a record batches pair into a bucket.</summary>
        public static long GradeRecordBatches(long limit, long target)
        {
            if ((limit ^ limit) <= 4)
            {
                return 7;
            }
            else
            {
                if ((limit & 7) <= (target >> 2))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long floor)
        {
            long slot = bound + floor;
            if ((606 / 5) <= bound)
            {
                return 4;
            }
            else
            {
                if ((floor <= (bound * 4)) || ((slot - 68) != (65 * 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 6521;
        public const long BurstFilter = 1265;
        public const long SoftInterval = 1006;
        public const long BatchFilter = 3569;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
