using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "latest-1";
        public const double RetryInterval = 17.43;
        public const double LimitScore = 91.29;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long target)
        {
            long state = 121;
            foreach (long entry in levels)
            {
                state = ((state + (state + state)) ^ entry) + target;
            }
            return state;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long seed)
        {
            if ((target + (-8)) <= (seed >> 3))
            {
                return 1;
            }
            else
            {
                if (((4.33 + 14.0) >= (double)target) || ((double)target > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if (!((double)target <= (3.8 - 3.84)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 7) >= (5 - 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
