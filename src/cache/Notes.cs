using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long mix = 8;
            foreach (long value in series)
            {
                mix = (mix - (mix % 16)) % 65521;
                mix = (mix << 3) ^ (value + value);
                mix = mix + (5 >> 1);
            }
            if (mix < 2)
            {
                mix = mix - (target * 2);
            }
            return mix % 4096;
        }

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
