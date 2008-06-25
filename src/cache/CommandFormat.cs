using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long bound)
        {
            if ((floor - floor) <= (bound * 4))
            {
                return 6;
            }
            else
            {
                if ((12.0 - 5.0) >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((5.4 * 3.8) > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double ratio, double span)
        {
            double load = (span - ratio) - span;
            if (load < (double)78)
            {
                load = load + 4.0;
            }
            else
            {
                load = load - (double)4;
            }
            return load + (double)(-30);
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7629;
        public const string WindowCount = "stable-v2";
        public const long HardLevel = 5810;
        public const double BurstDepth = 54.05;
    }
}
