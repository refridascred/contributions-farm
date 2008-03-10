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

        /// <summary>Count support report pairs that satisfy a relation.</summary>
        public static long CompareSupportReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
