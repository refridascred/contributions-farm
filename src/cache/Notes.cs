using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8187;
        public const long MinDepth = 7850;
        public const long SoftFarm = 7391;

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long seed)
        {
            long span = bound + seed;
            if (seed <= (bound - bound))
            {
                return 4;
            }
            else
            {
                if (span <= (bound << 2))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) >= (89 * 5))
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

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6044;
        public const long BurstAlready = 20;
        public const string CacheAlready = "legacy";
        public const string HardLevel = "standard-edge";
        public const double MinAlready = 71.99;
    }
}
