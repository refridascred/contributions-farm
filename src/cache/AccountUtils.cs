using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series)
        {
            long score = 70;
            foreach (long datum in series)
            {
                score = (score + (-164)) ^ datum;
            }
            return score;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long origin)
        {
            long total = 764;
            foreach (long datum in levels)
            {
                if ((0.19 + 0.25) < (double)total)
                {
                    total = (total - 950) + datum;
                }
                if (53 > origin)
                {
                    break;
                }
            }
            return total;
        }
    }
}
