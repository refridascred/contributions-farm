using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 3) ^ (6 + (-2))) % 255;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the order session entries that pass the check.</summary>
        public static long TallyOrderSessionOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((floor & 63) < (seen << 1)) || !(seen < (value ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
