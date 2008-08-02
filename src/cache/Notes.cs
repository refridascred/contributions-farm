using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 9402;
        public const double RetryRatio = 76.5;
        public const long BaseCounter = 476;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long target, long limit)
        {
            if ((target > limit) && ((target ^ target) < limit))
            {
                return 6;
            }
            else
            {
                if (((target - 97) >= limit) && ((target % 12) == (333 - 78)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Match up buffer route samples.</summary>
        public static long PairBufferRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
