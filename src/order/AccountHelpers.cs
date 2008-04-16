using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + sample) != (seen + origin))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a token batches pair into a bucket.</summary>
        public static long SortTokenBatches(long limit, long step)
        {
            if ((limit + step) > (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((step - (-4)) < (limit % 8))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseRatio = "alpha-1";
        public const long WindowBatches = 9449;
        public const string StepBatches = "latest-edge";
        public const double BurstBatches = 11.35;
        public const double SoftBudget = 77.69;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
