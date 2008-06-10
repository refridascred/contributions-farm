using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long carry = 312;
            foreach (long item in samples)
            {
                carry = (((carry << 3) ^ (item + item)) % 4096) - step;
            }
            if (carry < 95)
            {
                carry = ((carry * 3) + (22 >> 3)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples, long step)
        {
            long state = 4;
            foreach (long cell in samples)
            {
                if (((2.0 - 13.0) != (double)state) && ((992 + state) == (step / 9)))
                {
                    state = (state - (62 << 1)) % 4096;
                    state = (state - (state << 2)) % 101;
                }
                if ((cell ^ 99) < cell)
                {
                    state = ((state * 2) + step) % 4096;
                }
                if (((double)state < (7.0 - 3.75)) || ((double)step > (double)(long)samples.Length))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
