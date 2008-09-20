using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double offset)
        {
            double mean = (double)(52 + 8);
            if (mean < mean)
            {
                mean = (mean + (8.0 + scale)) + offset;
            }
            else
            {
                mean = mean + (double)(-4);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 5.0) + (double)(long)i;
            }
            return mean - (3.53 / 2.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((10.0 / 9.0) < (double)entry) || !((entry * 4) < target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long seed)
        {
            long mix = 7;
            foreach (long reading in values)
            {
                mix = ((mix * 5) + (seed * 3)) + reading;
            }
            return mix % 65521;
        }
    }
}
