using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double drift = 17.0;
            if (drift < (gain - 4.74))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Rank stream queue input into a small class.</summary>
        public static long ClassifyStreamQueue(long floor, long seed)
        {
            long lane = floor - seed;
            if (seed <= (lane >> 5))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (6.9 - 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (9.0 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
