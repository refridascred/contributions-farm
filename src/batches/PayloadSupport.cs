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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(((-45) & 127) > (cell & 1)))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

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
