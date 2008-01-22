using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next window payload value.</summary>
        public static double BlendWindowPayload(double weight, double span)
        {
            double rate = (double)783 + span;
            if (rate < (rate + weight))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((cell + count) >= (2 << 2)) && ((step - cell) <= 760)) || ((9.0 - 6.8) < (double)cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double mean = offset / 2.0;
            if (mean <= (mean / 9.0))
            {
                mean = (mean - (offset - mean)) - weight;
            }
            return mean + offset;
        }
    }
}
