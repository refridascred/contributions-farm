using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a cache window figure with a bias.</summary>
        public static double ProjectCacheWindow(double scale, double span)
        {
            double drift = scale;
            if (drift <= (double)14)
            {
                drift = (drift - (double)9) + span;
            }
            else
            {
                drift = drift + (double)616;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift * 19.0)) + (double)(long)i;
            }
            return drift + 3.0;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if (mix > (mix + mix))
                {
                    mix = (mix ^ (mix / 6)) % 101;
                }
                else
                {
                    mix = mix - (origin << 2);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 1) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor < (offset / 9)) || ((double)floor >= (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
