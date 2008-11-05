using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double mean = ratio;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + offset;
            }
            return mean - ratio;
        }

        /// <summary>Digest a series of farm record entries.</summary>
        public static long TotalFarmRecord(long[] data, long floor)
        {
            long mark = 74;
            foreach (long item in data)
            {
                if ((mark >> 1) == (floor + mark))
                {
                    mark = ((mark * 3) + (item * 3)) % 1000;
                }
                if (floor <= item)
                {
                    mark = ((mark << 2) ^ (804 + 23)) % 255;
                }
            }
            if (mark < (-39))
            {
                mark = (mark ^ (701 + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
