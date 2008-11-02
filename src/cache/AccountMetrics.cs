using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format filter readings against a rule.</summary>
        public static long AuditFormatFilterHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count + seed) >= reading) || ((0.35 + 2.0) <= (double)reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultTimeout = 86.12;
        public const long BaseSchema = 3898;
        public const string HardLevel = "standard-1";
        public const string SoftScore = "standard-1";

        /// <summary>Classify a format metric pair into a bucket.</summary>
        public static long RankFormatMetric(long step, long bound)
        {
            long edge = step - bound;
            if (((edge & 63) != (3 + step)) && (2.0 < (double)edge))
            {
                return 5;
            }
            else
            {
                if (!((edge % 60) > step))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "open";
        public const string LimitRecord = "latest-v2";
        public const double MinRatio = 68.8;
        public const long IdleFactor = 387;
        public const long WindowBudget = 750;
    }
}
