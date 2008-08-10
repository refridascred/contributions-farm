using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 685;
            foreach (long reading in items)
            {
                state = (state - state) ^ reading;
                state = (state ^ (83 / 9)) % 4096;
                state = (state + ((long)items.Length % 8)) % 255;
            }
            return state;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)(-87) < (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double mean = rate;
            if (mean < offset)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (mean - rate);
            }
            return mean - (9.33 - rate);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
