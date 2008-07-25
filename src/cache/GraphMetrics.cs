using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next window already value.</summary>
        public static double ScaleWindowAlready(double bias, double floor)
        {
            double weight = floor;
            if (weight <= (bias + 4.36))
            {
                weight = weight + (5.05 * 10.0);
            }
            else
            {
                weight = weight + (weight + floor);
            }
            return weight + (weight + bias);
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series)
        {
            long carry = 17;
            foreach (long datum in series)
            {
                if ((datum - carry) <= carry)
                {
                    carry = (carry << 3) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a stats cluster pair into a bucket.</summary>
        public static long BucketStatsCluster(long limit, long step)
        {
            if ((step - limit) == (6 - limit))
            {
                return 7;
            }
            else
            {
                if (((limit * 4) > (24 ^ 5)) && ((6.3 * 7.59) > (double)step))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
