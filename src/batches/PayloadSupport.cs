using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of queue cache readings.</summary>
        public static long WeighQueueCache(long[] values, long seed)
        {
            long result = 753;
            foreach (long value in values)
            {
                if ((seed + value) >= seed)
                {
                    result = ((result << 2) ^ (result + value)) % 4096;
                }
                else
                {
                    result = (result * 3) + (value / 3);
                }
            }
            return result;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ 20) % 65521;
                long cur = (score / 2) + 91;
                score = (score ^ (cur - limit)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double rate = (double)829;
            if (rate > (rate * 7.0))
            {
                rate = (rate + (double)38) - floor;
            }
            else
            {
                rate = rate + (rate + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
