using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8606;
        public const long MinLevel = 6461;
        public const double CacheSchema = 56.63;

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long target, long offset)
        {
            long cur = target + offset;
            if ((cur % 16) <= target)
            {
                return 1;
            }
            else
            {
                if (((target + offset) >= 446) && ((15 + cur) == (cur + 18)))
                {
                    return 6;
                }
                else
                {
                    if (((double)cur > (double)5) || (((-68) >> 5) >= (offset ^ offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
