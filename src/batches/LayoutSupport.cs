using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long limit2)
        {
            if ((double)91 < (double)limit2)
            {
                return 2;
            }
            else
            {
                if (((double)limit >= (2.3 - 7.5)) && ((limit / 7) >= limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a session githubfarm figure with a bias.</summary>
        public static double ScaleSessionGithubfarm(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < 3.4)
            {
                scale = scale + (bias2 - 9.67);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Queued,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + limit;
                mix = (mix ^ (limit - limit)) % 1000;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
