using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double load = offset;
            if (load < (offset / 6.0))
            {
                load = load - (load - rate);
            }
            else
            {
                load = load - (18.0 * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 7.36) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((limit - 4) >= (diff * 2))
            {
                return 0;
            }
            else
            {
                if ((limit + diff) >= (diff << 2))
                {
                    return 8;
                }
                else
                {
                    if (((3.99 + 8.32) <= (double)diff) && ((floor >> 3) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff >> 5) == (diff + limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = mean - (mean - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double mean = bias;
            return mean + (ratio + 3.1);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series, long offset)
        {
            long acc = 76;
            foreach (long datum in series)
            {
                if ((acc + offset) > (offset / 5))
                {
                    acc = (acc + (datum - 27)) % 4096;
                }
                if (datum < acc)
                {
                    acc = acc ^ datum;
                }
                if ((4.0 / 8.0) >= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
