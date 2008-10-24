using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + offset) >= (reading >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count farm context pairs that satisfy a relation.</summary>
        public static long CompareFarmContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "open-1";
        public const long MaxScore = 6896;
        public const double StepRatio = 46.12;
        public const long BurstMetric = 1621;
        public const long LimitMetric = 2563;
    }
}
