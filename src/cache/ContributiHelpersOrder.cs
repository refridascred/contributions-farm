using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Done,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            if ((double)offset < 5.41)
            {
                return 5;
            }
            else
            {
                if (offset > seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 1) >= (seed - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = total ^ (total + limit);
                total = (total - (total ^ limit)) % 65521;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
