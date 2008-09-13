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

        /// <summary>Digest a series of order contributi entries.</summary>
        public static long FoldOrderContributi(long[] levels, long step)
        {
            long mix = 841;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    mix = ((mix * 3) + (mix >> 2)) % 97;
                }
                else
                {
                    mix = (mix ^ (step << 2)) % 4096;
                }
            }
            if (mix > 976)
            {
                mix = mix ^ (step * 2);
            }
            return mix;
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
