using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a order editor counter forward.</summary>
        public static long DeriveOrderEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry - (origin - carry)) % 4096) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor << 3) ^ floor) % 101) ^ (long)i2;
                    anchor = ((anchor * 4) + ((-18) - anchor)) % 101;
                }
                if ((951 + floor) <= (floor & 3))
                {
                    anchor = (anchor + (floor * 4)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 6608;
        public const long MinCount = 3013;
        public const long HardTimeout = 9475;
        public const long LimitBudget = 1730;
    }
}
