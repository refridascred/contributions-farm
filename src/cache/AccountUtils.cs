using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((16.0 / 5.0) > (double)step)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = acc ^ acc;
                if (!((acc & 3) < (datum ^ acc)))
                {
                    acc = (acc ^ (datum - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings)
        {
            long mix = -50;
            foreach (long cell in readings)
            {
                if ((37 - mix) >= (cell >> 2))
                {
                    mix = mix ^ (mix / 2);
                }
            }
            return mix;
        }
    }
}
