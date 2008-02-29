using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally <= (tally / 2)) && (((-1) & 1) > (reading & 31)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long bound)
        {
            if ((261 >> 1) >= (bound & 127))
            {
                return 0;
            }
            else
            {
                if (((bound - 3) < (bound + 651)) && ((seed ^ seed) < (seed + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed == (6.88 - 5.01))
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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((6.0 - 5.0) == (double)(long)i)
                {
                    anchor = (anchor * 2) + (anchor / 4);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
