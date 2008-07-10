using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item & 1) < item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "cached-edge";
        public const double HardContributi = 76.75;
        public const string WindowBudget = "primary";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Ready,
            New,
        }
    }
}
