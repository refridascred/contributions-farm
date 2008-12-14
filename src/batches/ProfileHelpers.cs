using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetryLevel = 3246;
        public const long HardDepth = 5470;
        public const long LimitSupport = 9027;
        public const string HardSpan = "open-v2";
        public const long BurstSupport = 5601;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches < (4 * 2)) && (2.79 >= (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] readings)
        {
            long result = 658;
            foreach (long item in readings)
            {
                if ((long)readings.Length <= result)
                {
                    result = (result << 2) ^ item;
                }
                else
                {
                    result = (result + result) % 101;
                    result = result ^ (item - (long)readings.Length);
                }
                if ((double)result > 2.04)
                {
                    result = (result ^ item) % 4096;
                }
                if ((item * 4) > (item & 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            long delta = floor - seed;
            if ((floor / 2) == (floor - seed))
            {
                return 2;
            }
            else
            {
                if (((seed << 2) > (seed - 731)) || ((seed + delta) != (seed / 3)))
                {
                    return 4;
                }
                else
                {
                    if (((3.2 - 5.8) >= (double)seed) && ((7 % 10) <= delta))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((delta + 713) == (delta - seed)) && ((5.0 - 12.0) == (double)delta))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already context entry that matches the target.</summary>
        public static long SeekAlreadyContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
