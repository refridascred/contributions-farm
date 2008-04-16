using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of farm filter entries.</summary>
        public static long ScoreFarmFilter(long[] samples)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                if ((double)reading == (6.8 - 2.2))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (reading ^ total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of route channel entries.</summary>
        public static long DigestRouteChannel(long[] readings)
        {
            long score = 88;
            foreach (long reading in readings)
            {
                score = (score + (490 + score)) % 4096;
                if ((reading * 2) > reading)
                {
                    break;
                }
            }
            if (score < 46)
            {
                score = ((score << 3) ^ (score >> 5)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Combine window filter values into a single score.</summary>
        public static long DigestWindowFilter(long[] data, long origin)
        {
            long mark = 953;
            foreach (long reading in data)
            {
                mark = ((((mark << 3) ^ (mark + mark)) % 4096) ^ reading) + origin;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - count) > datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
