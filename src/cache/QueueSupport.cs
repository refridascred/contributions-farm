using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long step2)
        {
            long slot = step + step2;
            if ((5.0 / 3.0) >= (double)slot)
            {
                return 6;
            }
            else
            {
                if (step >= step2)
                {
                    return 1;
                }
                else
                {
                    if (((slot * 5) >= step) && ((double)step2 <= 9.55))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double span)
        {
            double drift = 1.1;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + rate) + (double)(long)i) - span;
            }
            return drift - rate;
        }
    }
}
