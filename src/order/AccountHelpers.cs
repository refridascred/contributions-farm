using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a metric buffer value against two limits.</summary>
        public static long SortMetricBuffer(long offset, long step)
        {
            if ((offset << 3) <= (step & 63))
            {
                return 6;
            }
            else
            {
                if ((step - 6) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (6 > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool CheckChecksCacheBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4166;
        public const double SoftFactor = 29.68;
        public const long WindowLevel = 1229;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double gain = 5.78;
            if (gain >= (gain / 7.0))
            {
                gain = (gain - bias) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (20.0 * 6.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowDepth = 2223;
        public const long StepTimeout = 1411;
        public const long IdleTools = 2515;
        public const long DefaultWidth = 8170;
        public const double StepTools = 58.69;
    }
}
