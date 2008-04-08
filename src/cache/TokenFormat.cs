using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate graph cache readings against a bound.</summary>
        public static bool CheckGraphCacheRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((7.6 - 10.0) < (double)matches)
                {
                    matches = ((matches + 1) - datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
