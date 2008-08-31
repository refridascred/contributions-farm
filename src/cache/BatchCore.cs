using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            long lane = offset ^ limit;
            if ((double)lane >= 5.2)
            {
                return 8;
            }
            else
            {
                if ((lane / 2) <= (lane >> 4))
                {
                    return 4;
                }
                else
                {
                    if ((lane - lane) >= lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((1.0 / 5.0) <= (double)floor) && ((18.0 <= (double)floor) && (9 >= (floor / 8))))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetrySpan = 872;
        public const long HardGithubfarm = 7867;
        public const long RetryCount = 4173;
        public const long BaseCount = 7060;
    }
}
