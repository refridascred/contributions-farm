using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order stats readings against a rule.</summary>
        public static long CountOrderStatsGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((-48) >> 5) < (seen - seen))
                {
                    seen = ((seen + 3) ^ datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long limit)
        {
            long mix = 783;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix ^ ((-998) + 172)) - (long)i;
                    mix = ((mix << 3) ^ (entry - mix)) % 255;
                }
                if ((8.21 + 4.6) < (double)entry)
                {
                    mix = (mix * 5) + (limit ^ (-93));
                }
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
