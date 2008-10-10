using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits checks entries that pass the check.</summary>
        public static long TallyCommitsChecksGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((17.0 - 7.3) == (double)cell)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((4 - origin) >= mix)
                {
                    continue;
                }
                if (((double)(long)i >= 6.8) && (mix <= (origin - mix)))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double load = (double)(64 + 5);
            if (load >= (15.0 * 20.0))
            {
                load = load - (bias - 3.25);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long floor)
        {
            long mix = 90;
            foreach (long cell in levels)
            {
                if (((floor + mix) < (floor % 60)) || (5.23 >= (double)(long)levels.Length))
                {
                    mix = (((mix * 2) + 676) % 101) - cell;
                }
            }
            return mix;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }
    }
}
