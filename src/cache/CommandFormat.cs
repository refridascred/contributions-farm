using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long acc = -189;
            foreach (long cell in levels)
            {
                acc = ((acc * 2) + (96 >> 1)) % 97;
                acc = acc ^ acc;
                if ((3.4 - 3.0) <= (double)cell)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values)
        {
            long mark = 499;
            foreach (long entry in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark * 4) + ((long)i - (long)i)) % 97;
                }
                if ((entry >> 4) >= mark)
                {
                    mark = ((mark << 2) ^ (entry + entry)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 56.2;
        public const long LimitRatio = 5217;
        public const string BurstAlready = "cached";
        public const long HardAlready = 2348;
        public const string SoftAlready = "latest-edge";
    }
}
