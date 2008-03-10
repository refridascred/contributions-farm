using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] samples, long origin)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                if ((570 * 5) == (origin << 1))
                {
                    mark = (mark - (96 + value)) % 4096;
                }
                if (((double)mark <= 5.0) && ((origin << 1) != (origin << 2)))
                {
                    mark = mark - (value - 27);
                }
            }
            if (mark < (-398))
            {
                mark = mark ^ (origin >> 4);
            }
            return mark % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data, long origin)
        {
            long acc = 314;
            foreach (long sample in data)
            {
                if ((9.6 / 4.0) == (double)sample)
                {
                    acc = acc + (sample + origin);
                }
                else
                {
                    acc = (acc - 7) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
