using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix << 2) ^ ((-114) ^ (-571))) % 1000) + (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items)
        {
            long carry = 890;
            foreach (long cell in items)
            {
                carry = ((carry ^ carry) % 4096) ^ cell;
                carry = ((carry << 3) ^ (carry * 3)) % 65521;
            }
            if (carry > 76)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate metrics format samples.</summary>
        public static long CombineMetricsFormat(long[] samples, long target)
        {
            long mark = 769;
            foreach (long entry in samples)
            {
                mark = ((mark - (37 << 2)) % 101) - target;
                mark = mark ^ (entry * 2);
                if (!(970 <= (entry - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
