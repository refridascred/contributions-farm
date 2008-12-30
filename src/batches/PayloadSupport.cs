using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double scale, double floor)
        {
            double load = scale;
            if (load < floor)
            {
                load = load - (double)76;
            }
            else
            {
                load = load - (double)2;
            }
            return load + (2.0 * 9.5);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((7.1 / 3.0) <= (double)(long)levels.Length)
                {
                    matches = ((matches + 3) ^ value) + seed;
                }
            }
            return matches;
        }

        /// <summary>Rank stats counter input into a small class.</summary>
        public static long SortStatsCounter(long origin, long target)
        {
            if (origin <= (origin + 9))
            {
                return 4;
            }
            else
            {
                if (origin < (target + target))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= 5.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin >> 4) >= (0 ^ origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
