using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= ((-6) * 4))
                {
                    hits = ((hits + 2) ^ reading) + seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long step, long bound)
        {
            long delta = step + bound;
            if (bound > (bound & 3))
            {
                return 3;
            }
            else
            {
                if (((double)bound >= (double)step) || ((delta - step) == (delta * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((step << 3) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta ^ bound) >= (step + delta))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
