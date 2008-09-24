using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series, long seed)
        {
            long mix = 13;
            foreach (long sample in series)
            {
                if (seed >= (1 + mix))
                {
                    mix = (mix + (seed * 2)) % 97;
                }
                if ((((long)series.Length + seed) < (seed + seed)) && (((-675) + sample) == (mix - sample)))
                {
                    mix = mix + (mix + sample);
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally << 2) < (item ^ item))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
