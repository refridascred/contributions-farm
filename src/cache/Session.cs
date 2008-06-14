using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream account readings against a rule.</summary>
        public static long CountStreamAccountMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            if (seed > (seed + seed2))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (5.0 + 3.61))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + seed) >= (seed2 + seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(31 > seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items, long offset)
        {
            long acc = 611;
            foreach (long sample in items)
            {
                acc = (acc << 2) ^ acc;
                acc = ((acc << 3) ^ (offset + (-158))) % 97;
                if ((11.0 - 10.0) >= (double)sample)
                {
                    acc = (acc - offset) % 97;
                }
                else
                {
                    acc = acc - (284 + sample);
                }
            }
            return acc % 4096;
        }
    }
}
