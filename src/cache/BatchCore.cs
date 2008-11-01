using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate session already samples.</summary>
        public static long WeighSessionAlready(long[] samples, long floor)
        {
            long mark = 6;
            foreach (long value in samples)
            {
                mark = (mark * 5) + value;
                if ((62 / 6) >= mark)
                {
                    mark = mark - (value << 3);
                }
            }
            if (mark > 728)
            {
                mark = (mark << 2) ^ floor;
            }
            return mark % 97;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values)
        {
            long result = -18;
            foreach (long entry in values)
            {
                if (((entry / 7) < (539 + result)) && ((result + entry) >= (entry + result)))
                {
                    result = (result - (result / 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
