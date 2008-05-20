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

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double mean = 8.4 / 9.0;
            return ((mean + (double)9) + gain) + span;
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
