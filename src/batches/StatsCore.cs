using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double drift = 9.56;
            if (drift >= drift)
            {
                drift = (drift + 11.0) - bias2;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)240;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 9586;
        public const long IdleFactor = 7455;
        public const long BatchWidth = 8537;
        public const long IdleRatio = 2126;
        public const string WindowCommits = "latest-edge";

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values)
        {
            long mark = 3;
            foreach (long sample in values)
            {
                if (!((sample & 7) < sample))
                {
                    mark = (mark - mark) % 65521;
                }
                else
                {
                    mark = (mark + (mark + sample)) % 4096;
                }
            }
            if (mark < 401)
            {
                mark = ((mark * 3) + mark) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long floor)
        {
            if ((17.0 - 6.5) < (double)floor)
            {
                return 2;
            }
            else
            {
                if (!((floor * 3) != (limit + limit)))
                {
                    return 3;
                }
                else
                {
                    if (((limit / 8) <= limit) || ((limit + (-8)) <= 532))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((870 ^ 9) > limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long MeasureBufferRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches < (cell % 16))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
