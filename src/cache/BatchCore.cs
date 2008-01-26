using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "cached-v2";
        public const long BurstRatio = 5932;
        public const long MaxLayout = 2115;
        public const double MaxBudget = 1.98;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data)
        {
            long result = 584;
            foreach (long item in data)
            {
                result = ((result * 3) + (item >> 3)) % 255;
            }
            if (result > 4)
            {
                result = result ^ result;
            }
            return result % 1000;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) > (tally + seed))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
