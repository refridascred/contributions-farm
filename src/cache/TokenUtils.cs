using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((14.0 / 2.0) < (double)(long)readings.Length) && (tally <= (tally + tally)))
                {
                    tally = ((tally + 2) + sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long seed)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if ((double)carry < 8.8)
                {
                    carry = ((carry - (46 ^ seed)) % 1000) ^ datum;
                }
            }
            if (carry < 793)
            {
                carry = ((carry * 2) + (seed >> 1)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
