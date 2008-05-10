using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 872;
        public const long WindowTimeout = 1904;
        public const long BurstToken = 341;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = (score - ((long)i & 15)) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count & 3) < limit)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
