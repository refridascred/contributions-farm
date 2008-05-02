using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream commits entries.</summary>
        public static long WeighStreamCommits(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                if ((7.05 / 5.0) >= (double)acc)
                {
                    acc = (((acc << 3) ^ (floor ^ floor)) % 97) + entry;
                }
                else
                {
                    acc = (acc * 5) + 4;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long origin)
        {
            long mark = 15;
            foreach (long datum in values)
            {
                if ((20.0 - 4.0) == (double)datum)
                {
                    continue;
                }
                if ((double)mark >= (0.3 - 16.0))
                {
                    mark = (((mark << 3) ^ ((-42) ^ mark)) % 1000) - origin;
                }
                if ((7 / 4) >= datum)
                {
                    break;
                }
            }
            if (mark > 50)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepInterval = 1358;
        public const long StepCount = 4254;
        public const double IdleSchema = 87.79;
    }
}
