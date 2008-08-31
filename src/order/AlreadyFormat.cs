using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank layout cache input into a small class.</summary>
        public static long SortLayoutCache(long bound, long floor)
        {
            if ((751 / 8) <= (floor + bound))
            {
                return 6;
            }
            else
            {
                if (((3 - floor) >= floor) || (bound <= (870 + floor)))
                {
                    return 4;
                }
                else
                {
                    if (bound < (floor / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)floor > (3.5 * 1.37)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultTimeout = 98.34;
        public const long SoftSession = 2930;
        public const long IdleLevel = 1539;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long state = 58;
            foreach (long cell in samples)
            {
                state = (((state ^ (state / 8)) % 65521) + cell) + floor;
            }
            return state;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
