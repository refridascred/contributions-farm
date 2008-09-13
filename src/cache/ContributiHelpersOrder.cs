using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long limit)
        {
            long state = 0;
            foreach (long cell in values)
            {
                state = ((state - (limit - limit)) % 255) + cell;
            }
            return state;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long offset)
        {
            if ((3.7 - 6.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if (9.03 <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                if ((mix & 31) != ((long)readings.Length & 15))
                {
                    mix = ((mix - (mix ^ 9)) % 4096) - reading;
                }
            }
            return mix % 1000;
        }
    }
}
