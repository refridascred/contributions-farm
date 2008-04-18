using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double drift = offset;
            if (drift > 2.42)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + 4.5;
            }
            return drift - (scale - scale);
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long offset)
        {
            long next = target + offset;
            if ((double)next != (5.0 + 8.0))
            {
                return 7;
            }
            else
            {
                if ((target / 7) > next)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
