using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a token metrics value against two limits.</summary>
        public static long RankTokenMetrics(long offset, long target)
        {
            if ((target >= (offset & 15)) || (offset < (target << 2)))
            {
                return 8;
            }
            else
            {
                if (((target * 5) >= target) && (target >= (target + target)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLevel = 9870;
        public const long BatchSize = 4577;
        public const double MaxLayout = 16.37;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)(long)data.Length == (double)0) && ((floor / 3) <= (floor + tally)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                if ((265 * 3) != (160 - cell))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
                else
                {
                    carry = (carry - (4 + 6)) % 4096;
                }
            }
            if (carry < 929)
            {
                carry = ((carry << 2) ^ (8 - 64)) % 101;
            }
            return carry;
        }
    }
}
