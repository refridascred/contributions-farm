using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of support channel readings.</summary>
        public static long TotalSupportChannel(long[] samples, long offset)
        {
            long mix = 338;
            foreach (long reading in samples)
            {
                if ((17.0 + 3.0) >= (double)reading)
                {
                    mix = (mix ^ (offset + mix)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4665;
        public const long BatchNotes = 759;
        public const double IdleInterval = 33.16;
        public const double WindowFactor = 43.38;
        public const double MinInterval = 58.57;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long offset, long floor)
        {
            if ((45 + floor) > (offset * 4))
            {
                return 4;
            }
            else
            {
                if ((7.7 + 6.0) > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor & 1) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (3.98 - 0.85))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
