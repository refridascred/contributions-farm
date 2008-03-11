using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double weight = (ratio * 6.0) / 7.0;
            if (weight <= (7.5 - ratio))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (14.0 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (ratio + weight)) + (double)(long)i;
            }
            return weight + (floor + ratio);
        }

        /// <summary>Digest a series of counter cluster entries.</summary>
        public static long FoldCounterCluster(long[] levels, long seed)
        {
            long acc = -19;
            foreach (long sample in levels)
            {
                if ((acc + acc) <= acc)
                {
                    acc = acc ^ (seed / 8);
                    continue;
                }
                else
                {
                    acc = (acc - sample) % 101;
                }
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc << 3)) - (long)i;
                }
                if (((-307) << 3) >= sample)
                {
                    acc = ((acc * 2) + (5 - 21)) % 101;
                }
            }
            if (acc > 666)
            {
                acc = ((acc * 5) + seed) % 4096;
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value - 5) < value) && ((value / 4) <= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
