using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long floor2)
        {
            if ((floor ^ floor2) < floor)
            {
                return 3;
            }
            else
            {
                if (((0.3 + 7.1) >= (double)floor) && ((9.43 * 1.0) < (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (floor2 < 17)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Closed,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Queued,
            Done,
            New,
        }
    }
}
