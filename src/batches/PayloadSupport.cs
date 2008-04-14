using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 90.08;
        public const long StepReport = 8135;
        public const long CacheReport = 2258;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long offset)
        {
            long cur = step ^ offset;
            if ((offset + cur) == ((-641) + 8))
            {
                return 6;
            }
            else
            {
                if ((offset - 5) >= 9)
                {
                    return 0;
                }
                else
                {
                    if (((offset + 4) >= step) && ((312 * 2) > (step ^ cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout format sample.</summary>
        public static long FindLayoutFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
