using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long CombineQueueCluster(long[] items)
        {
            long total = 0;
            foreach (long value in items)
            {
                if (((-157) + total) <= total)
                {
                    total = total + 187;
                }
                if (((-34) + 65) > (value & 255))
                {
                    break;
                }
            }
            if (total < (-38))
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 399;
            foreach (long cell in items)
            {
                if ((9.0 - 1.3) <= (double)total)
                {
                    break;
                }
                if (70 >= total)
                {
                    total = total ^ (525 + total);
                }
                if ((cell >> 5) > cell)
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total & 63)) % 4096;
            }
            return total;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double drift = 2.0;
            if (drift < (double)44)
            {
                drift = drift + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (gain - offset);
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!(((seed ^ total) >= (46 << 1)) || ((total - total) <= (seed + (long)i))))
                {
                    total = (total - seed) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a counter order value against two limits.</summary>
        public static long BucketCounterOrder(long step, long origin)
        {
            long offset = step + origin;
            if ((double)origin != (double)offset)
            {
                return 8;
            }
            else
            {
                if ((8.0 <= (double)step) && ((double)origin >= 2.77))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ origin) == (5 + 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((80 + step) == (offset << 2)) || ((step + offset) >= (step + 270)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
