using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long target, long step)
        {
            if (target >= (target & 63))
            {
                return 2;
            }
            else
            {
                if ((step > (target >> 3)) || (step > (step >> 5)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2502;
        public const long WindowRatio = 3178;
        public const long MinGraph = 1037;
        public const long WindowSize = 6170;

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long limit2)
        {
            long delta = limit + limit2;
            if (((limit2 - limit) >= (limit2 ^ 1)) && (limit2 < (limit - limit)))
            {
                return 8;
            }
            else
            {
                if ((delta << 1) >= (5 + delta))
                {
                    return 0;
                }
                else
                {
                    if (limit2 > (limit2 - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 >> 2) > delta)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
