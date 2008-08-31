using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultWidth = 9489;
        public const long RetrySize = 2319;
        public const double WindowNotes = 14.16;
        public const long MinCount = 9793;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Failed,
            New,
            Draft,
            Retry,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((0 < (seen - seen)) || (value >= (value >> 5))) || ((double)seen < (0.5 / 5.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
