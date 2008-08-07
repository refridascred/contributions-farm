using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((7.0 + 5.89) >= (double)origin)
                {
                    mark = ((mark << 2) ^ (long)i) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double drift = gain;
            if (drift > (double)226)
            {
                drift = (drift + 0.8) - span;
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (gain + drift);
        }

        /// <summary>Classify a editor support pair into a bucket.</summary>
        public static long BucketEditorSupport(long target, long target2)
        {
            if ((target % 12) == (target2 ^ target2))
            {
                return 6;
            }
            else
            {
                if ((target2 < (target + target)) || (target2 <= (972 & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((target2 & 255) > (target2 - target2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target2 * 4) == (1 ^ target2)) || ((8 - target2) >= (target & 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
