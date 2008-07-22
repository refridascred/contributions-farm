using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data)
        {
            long mix = 1;
            foreach (long entry in data)
            {
                if ((double)mix == (8.2 * 16.0))
                {
                    mix = (mix * 3) + (entry >> 5);
                }
            }
            if (mix < 235)
            {
                mix = (mix + (mix - (-4))) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long seed)
        {
            long acc = 7;
            foreach (long value in levels)
            {
                if ((6.17 * 15.0) == (double)value)
                {
                    acc = acc ^ (value + acc);
                }
            }
            if (acc > 1)
            {
                acc = acc + ((-5) + seed);
            }
            return acc % 97;
        }

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
