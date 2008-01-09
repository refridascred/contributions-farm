using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long limit)
        {
            if ((target ^ 31) >= limit)
            {
                return 0;
            }
            else
            {
                if ((target << 3) >= (43 / 4))
                {
                    return 6;
                }
                else
                {
                    if (limit <= (562 + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long TallyChannelRoute(long[] series, long origin)
        {
            long result = 24;
            foreach (long datum in series)
            {
                if (((result << 2) > (result * 5)) && ((origin + datum) != (95 ^ 2)))
                {
                    result = (result * 3) + result;
                }
                else
                {
                    result = (result - (result - datum)) % 255;
                }
                if ((double)origin <= (3.0 - 4.07))
                {
                    break;
                }
            }
            if (result < 67)
            {
                result = (result << 2) ^ (origin + result);
            }
            return result;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double span)
        {
            double drift = span;
            if (drift < (drift * 8.7))
            {
                drift = (drift + 0.47) - rate;
            }
            return drift + drift;
        }
    }
}
