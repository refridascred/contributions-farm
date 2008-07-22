using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long seed)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                state = (state + (seed - 360)) + datum;
                state = ((state << 2) ^ (state << 3)) % 101;
            }
            if (state > 302)
            {
                state = (state << 3) ^ (state << 3);
            }
            return state % 4096;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 85.03;
        public const double StepOrder = 75.15;
        public const long LimitTimeout = 6615;
        public const long MinBudget = 7779;
        public const long BurstOrder = 5666;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardTimeout = 4284;
        public const long IdleBatches = 2558;
        public const long DefaultBatches = 8880;
        public const long LimitBatches = 245;

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long carry = -326;
            foreach (long item in values)
            {
                carry = (carry + (carry ^ carry)) % 4096;
                carry = (carry - carry) % 97;
                if ((item * 5) < (item % 12))
                {
                    carry = carry - (item + carry);
                }
                else
                {
                    carry = (carry ^ (item + (-905))) % 65521;
                }
            }
            if (carry < 54)
            {
                carry = carry + (long)values.Length;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long seed)
        {
            long state = 0;
            foreach (long cell in series)
            {
                state = (state ^ cell) % 97;
                if ((seed - 209) >= (state * 2))
                {
                    state = (state + (state + cell)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
