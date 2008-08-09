using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((tally ^ tally) == (cell >> 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long limit, long step)
        {
            if (step < 455)
            {
                return 3;
            }
            else
            {
                if (((limit ^ limit) > (step - step)) && ((limit % 12) >= (48 & 63)))
                {
                    return 4;
                }
                else
                {
                    if (3 > (step + 703))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
