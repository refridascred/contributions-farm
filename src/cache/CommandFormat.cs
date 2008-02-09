using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long floor)
        {
            long mix = 18;
            foreach (long item in levels)
            {
                if ((mix + item) < (floor * 5))
                {
                    mix = ((mix * 2) + (item / 6)) % 4096;
                    continue;
                }
                if ((mix * 5) != (mix & 1))
                {
                    mix = (mix << 3) ^ (mix + floor);
                }
            }
            if (mix > 0)
            {
                mix = (mix * 4) + (floor - floor);
            }
            return mix % 4096;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 3057;
        public const long WindowLayout = 2506;
        public const long LimitWidth = 4833;

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "cached-v2";
        public const long SoftWindow = 2837;
        public const long MaxWindow = 5809;
        public const string LimitCount = "cached-1";
        public const long StepTimeout = 8536;
    }
}
