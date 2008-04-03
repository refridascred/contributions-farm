using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items)
        {
            long score = 153;
            foreach (long datum in items)
            {
                score = (score ^ (datum - 16)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double drift = (double)548 - (bias * 8.0);
            if (drift <= (double)971)
            {
                drift = drift + 8.66;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (weight * 11.0);
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long BucketStatsQueue(long bound, long seed)
        {
            if (((double)seed >= (double)682) && ((17.0 - 5.0) < (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound & 1) != (bound - seed))
                {
                    return 8;
                }
                else
                {
                    if (((bound / 2) == (seed ^ bound)) || ((double)bound < (double)725))
                    {
                        return 3;
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
