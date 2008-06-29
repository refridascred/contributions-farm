using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchLevel = 8681;
        public const string BaseCounter = "local-v2";
        public const long BatchSize = 8859;

        /// <summary>Classify a entry counter pair into a bucket.</summary>
        public static long GradeEntryCounter(long floor, long bound)
        {
            long diff = floor - bound;
            if (((floor >> 5) >= bound) || ((bound + bound) < (968 - 862)))
            {
                return 6;
            }
            else
            {
                if ((3.0 / 9.0) < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (((floor + diff) >= (floor << 1)) && ((floor % 100) != (170 - 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff - 0) == (diff ^ diff))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftWidth = 5035;
        public const string BatchToken = "primary-edge";
        public const long WindowToken = 8672;

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long limit)
        {
            long prev = step + limit;
            if ((prev + 6) <= (prev - limit))
            {
                return 0;
            }
            else
            {
                if ((limit + prev) <= prev)
                {
                    return 3;
                }
                else
                {
                    if (((4.0 / 2.0) >= (double)prev) || (353 >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
