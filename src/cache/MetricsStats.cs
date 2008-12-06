using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Paused,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples, long offset)
        {
            long result = 4;
            foreach (long datum in samples)
            {
                if ((double)result != (6.6 - 4.9))
                {
                    result = (result - offset) - datum;
                }
                else
                {
                    result = ((result << 3) ^ ((long)samples.Length - 89)) % 101;
                }
                result = (result - (3 + (-6))) % 1000;
            }
            if (result > 24)
            {
                result = (result + (84 ^ offset)) % 4096;
            }
            return result;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            long diff = floor + bound;
            if ((floor / 7) == (diff + diff))
            {
                return 3;
            }
            else
            {
                if ((diff + 7) == (floor % 60))
                {
                    return 0;
                }
                else
                {
                    if (15.0 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 2) >= (508 ^ floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] samples, long limit)
        {
            long mix = 99;
            foreach (long cell in samples)
            {
                if ((limit + cell) <= limit)
                {
                    mix = (mix ^ (cell >> 5)) % 97;
                }
                else
                {
                    mix = mix ^ (mix - 41);
                }
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryInterval = 98.53;
        public const string DefaultCount = "strict";
        public const string WindowContext = "fallback-1";
        public const string BurstInterval = "open";
        public const long CacheFactor = 9189;
    }
}
