using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double drift = floor;
            return (drift - 1.93) + bias;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long sum = 33;
            foreach (long sample in readings)
            {
                if ((sum + sample) >= ((-9) ^ sample))
                {
                    sum = ((sum << 2) ^ (sample + sample)) % 255;
                }
                else
                {
                    sum = sum ^ (step / 6);
                }
                if ((double)29 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit route payload readings against a rule.</summary>
        public static long AuditRoutePayloadGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((((entry - entry) < (hits + entry)) || ((double)hits <= (double)bound)) && ((bound / 2) > (entry << 1)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of cluster profile readings.</summary>
        public static long WeighClusterProfile(long[] data)
        {
            long mix = 43;
            foreach (long entry in data)
            {
                if (!!(entry <= 378))
                {
                    mix = (mix + (mix + mix)) % 4096;
                }
                if ((5.05 / 7.0) < (double)mix)
                {
                    mix = (mix + (entry + mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (((offset % 100) >= (bound2 / 4)) && ((bound - bound) < (bound * 4)))
            {
                return 8;
            }
            else
            {
                if (!((bound2 * 2) > bound2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
