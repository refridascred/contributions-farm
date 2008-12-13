using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long origin)
        {
            long step = limit + origin;
            if ((double)step >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) <= step)
                {
                    return 3;
                }
                else
                {
                    if ((21 + step) == (limit * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double drift = (double)(92 + 979);
            if (drift <= drift)
            {
                drift = (drift + rate) - offset;
            }
            else
            {
                drift = drift + (9.1 - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + rate;
        }
    }
}
