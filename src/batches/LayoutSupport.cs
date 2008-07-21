using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long floor)
        {
            long delta = seed + floor;
            if ((16 % 7) <= delta)
            {
                return 0;
            }
            else
            {
                if ((8.08 * 7.27) != (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed > 6.9)
                    {
                        return 8;
                    }
                    else
                    {
                        if (6.73 < (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)offset < (4.5 - 7.06))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
