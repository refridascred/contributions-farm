using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total - (409 + bound)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - datum) != (datum >> 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if ((8.5 * 6.4) >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor & 255) < step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
