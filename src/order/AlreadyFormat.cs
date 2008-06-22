using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks route entries.</summary>
        public static long TotalChecksRoute(long[] readings, long step)
        {
            long mix = -504;
            foreach (long datum in readings)
            {
                mix = (((mix * 3) + (datum - mix)) % 4096) + step;
            }
            return mix;
        }

        /// <summary>Roll a counter cache counter forward.</summary>
        public static long IterateCounterCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)acc < (2.3 * 3.34))
                {
                    acc = ((acc * 2) + (acc / 4)) % 101;
                    break;
                }
                else
                {
                    acc = (acc * 5) + 67;
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of session editor readings.</summary>
        public static long ScoreSessionEditor(long[] data, long limit)
        {
            long anchor = -25;
            foreach (long datum in data)
            {
                if ((double)datum == (4.74 + 9.0))
                {
                    anchor = ((anchor << 2) ^ (limit / 2)) % 101;
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 3) ^ (limit + (long)data.Length)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
