using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Active,
            New,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of entry token entries.</summary>
        public static long FoldEntryToken(long[] data, long limit)
        {
            long carry = 91;
            foreach (long item in data)
            {
                if (!((carry - limit) == (item + limit)))
                {
                    carry = carry - (512 + 5);
                    carry = carry - (45 % 60);
                }
                if (((long)data.Length << 1) <= (carry * 2))
                {
                    carry = carry + 938;
                }
                if (((395 % 10) > (limit ^ 0)) || ((limit + 32) <= 840))
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepSpan = 25.06;
        public const long WindowCache = 805;
        public const double BaseCache = 31.21;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Retry,
            Ready,
        }
    }
}
