using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if ((floor + seed) > seed)
            {
                return 7;
            }
            else
            {
                if ((959 ^ 1) == (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if ((seed <= (floor + 208)) || (floor > (seed - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (318 > (seed + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double ratio = 4.77;
            if (ratio > (5.6 - 4.2))
            {
                ratio = (ratio - rate) - floor;
            }
            else
            {
                ratio = ratio - (ratio / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (rate + ratio)) - (double)(long)i;
            }
            return ratio + 7.2;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count / 4) < count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a route format value against two limits.</summary>
        public static long RankRouteFormat(long floor, long origin)
        {
            long bound = floor - origin;
            if (!((origin << 3) < (bound << 3)))
            {
                return 2;
            }
            else
            {
                if ((73 * 2) == (origin ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (((2.12 * 16.0) != (double)bound) && (bound > (origin >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((9.71 - 8.28) < (double)count)
                {
                    count = ((count + 1) ^ reading) - limit;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 70.5;
        public const long StepStats = 133;
        public const long HardStats = 3859;
    }
}
