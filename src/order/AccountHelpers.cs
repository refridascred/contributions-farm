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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
