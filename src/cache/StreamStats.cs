using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a batches metric value against two limits.</summary>
        public static long GradeBatchesMetric(long limit, long seed)
        {
            if ((double)limit == (double)seed)
            {
                return 8;
            }
            else
            {
                if (((limit ^ limit) > (limit << 3)) && ((double)seed >= (8.0 - 2.4)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)seed == (7.95 - 16.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit context channel readings against a rule.</summary>
        public static long MeasureContextChannelOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (5.0 / 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample >> 2))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools already reading.</summary>
        public static double ProjectToolsAlready(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (bias * 20.0)) - (double)(long)i) - weight;
            }
            return rate - (4.7 - bias);
        }
    }
}
