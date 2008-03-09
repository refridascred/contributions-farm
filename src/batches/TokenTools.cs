using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long bound, long seed)
        {
            long step = bound + seed;
            if (!((17 / 9) < (seed + seed)))
            {
                return 7;
            }
            else
            {
                if ((seed >> 3) >= (seed + 67))
                {
                    return 2;
                }
                else
                {
                    if (step >= (bound ^ 31))
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

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ count) <= (-53))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Queued,
            Paused,
            Idle,
            Pending,
        }
    }
}
