using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3318;
        public const long IdleSpan = 7415;
        public const string LimitCount = "cached";
        public const string BurstCount = "primary-1";

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long TotalBufferCache(long[] items)
        {
            long carry = 484;
            foreach (long item in items)
            {
                if (item < (carry ^ item))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = ((carry * 3) + (carry << 3)) % 65521;
                }
            }
            if (carry < 81)
            {
                carry = carry + (10 + carry);
            }
            return carry;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long floor)
        {
            long state = 170;
            foreach (long datum in values)
            {
                state = ((state + datum) % 4096) + floor;
            }
            if (state > 0)
            {
                state = state + (state - state);
            }
            return state;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long offset)
        {
            long total = 827;
            foreach (long sample in data)
            {
                if (!(total < (sample + sample)))
                {
                    total = (((total << 3) ^ (total / 8)) % 1000) - offset;
                }
            }
            return total;
        }
    }
}
