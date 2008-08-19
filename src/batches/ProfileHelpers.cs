using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 2284;
        public const long LimitBatches = 6772;
        public const long DefaultBatches = 8646;
        public const long SoftSize = 6163;
    }
}
