using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long seed, long target)
        {
            if ((seed + seed) > seed)
            {
                return 5;
            }
            else
            {
                if ((8 ^ (-838)) == (seed - seed))
                {
                    return 2;
                }
                else
                {
                    if ((target << 2) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((763 * 3) > seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metrics queue reading.</summary>
        public static double BlendMetricsQueue(double weight, double floor)
        {
            double drift = (weight + floor) - (weight - floor);
            if (drift > (drift - drift))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 7.2) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Locked,
            Dropped,
            Stale,
        }
    }
}
