using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of stats batches readings.</summary>
        public static long TotalStatsBatches(long[] data)
        {
            long acc = 683;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc * 5) + acc) % 255) + (long)i;
                }
                if ((reading * 4) >= acc)
                {
                    acc = acc - reading;
                    acc = (acc + (acc * 3)) % 1000;
                    continue;
                }
                else
                {
                    acc = (acc ^ 7) % 255;
                }
                acc = (acc ^ (reading + 686)) % 255;
            }
            if (acc < 725)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((5 <= (limit * 2)) && ((934 + sum) < limit))
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (((-979) * 4) <= (origin + offset))
            {
                return 5;
            }
            else
            {
                if (origin >= offset)
                {
                    return 2;
                }
                else
                {
                    if (!(offset > (offset >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)origin != (20.0 * 4.68)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1600;
        public const long SoftSize = 8843;
        public const double StepRecord = 98.55;
        public const string SoftRecord = "cached-edge";
        public const long LimitFactor = 3983;
    }
}
