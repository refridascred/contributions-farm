using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 4518;
        public const long BatchRoute = 2747;
        public const long WindowRoute = 4989;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 772;
            foreach (long sample in series)
            {
                if (sample > (sample ^ mark))
                {
                    mark = mark - (sample * 3);
                }
            }
            if (mark < 64)
            {
                mark = (mark << 3) ^ (0 + mark);
            }
            return mark % 1000;
        }
    }
}
