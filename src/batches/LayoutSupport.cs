using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long floor)
        {
            if ((origin ^ 23) <= origin)
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (2.4 + 9.9))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every cache layout entry stays within the limit.</summary>
        public static bool GuardCacheLayoutBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = (result + ((long)i - result)) % 101;
                result = ((result << 2) ^ (offset & 63)) % 4096;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseLevel = "cached-edge";
        public const long DefaultSupport = 1354;
        public const long SoftSupport = 9965;
        public const long StepSupport = 2152;
        public const double BatchCount = 74.44;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
