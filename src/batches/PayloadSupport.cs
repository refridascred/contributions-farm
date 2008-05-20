using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BurstLevel = 92.89;
        public const long SoftRatio = 9165;
        public const string LimitAlready = "latest";

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 9113;
        public const long WindowSize = 4436;
        public const long IdleScore = 6005;
        public const double MaxReport = 26.91;
        public const long WindowReport = 4171;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(((double)sample != (9.58 - 5.64)) && ((7.1 - 2.2) != (double)(long)levels.Length)))
                {
                    count = (count + 2) - step;
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
