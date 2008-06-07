using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long origin)
        {
            long step = target - origin;
            if ((origin > (target - step)) || ((7.9 / 2.0) < (double)target))
            {
                return 7;
            }
            else
            {
                if (((6.0 * 2.35) < (double)step) || ((6 - step) < step))
                {
                    return 0;
                }
                else
                {
                    if ((46 + target) == (target * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double drift = (double)781 * 1.0;
            if (drift <= drift)
            {
                drift = (drift - (double)3) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + (drift / 6.0);
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
