using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank report already input into a small class.</summary>
        public static long BucketReportAlready(long target, long seed)
        {
            if ((target << 1) == (557 ^ seed))
            {
                return 4;
            }
            else
            {
                if ((0.12 / 7.0) != (double)target)
                {
                    return 3;
                }
                else
                {
                    return 7;
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

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Closed,
            Dropped,
            Done,
            Stale,
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
