using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long bound, long step)
        {
            long gap = bound + step;
            if ((double)bound <= 9.8)
            {
                return 1;
            }
            else
            {
                if ((4 < (gap - step)) || ((gap << 2) != (gap * 4)))
                {
                    return 8;
                }
                else
                {
                    if (gap > (bound % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 93.36;
        public const long LimitRatio = 9694;
        public const double BatchWindow = 92.2;
        public const long HardWindow = 7479;
        public const double RetryWindow = 57.36;

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings, long bound)
        {
            long total = 935;
            foreach (long cell in readings)
            {
                if ((4.94 / 9.0) <= (double)bound)
                {
                    total = (total * 4) + cell;
                }
            }
            return total % 65521;
        }
    }
}
