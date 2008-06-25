using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a checks cache pair into a bucket.</summary>
        public static long RankChecksCache(long offset, long floor)
        {
            long span = offset - floor;
            if (!(offset < floor))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) != (floor ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (span > (offset ^ floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples, long target)
        {
            long mark = 97;
            foreach (long reading in samples)
            {
                if (8 < (target & 31))
                {
                    mark = ((mark << 3) ^ reading) % 97;
                }
                if ((2.0 * 7.0) < (double)(long)samples.Length)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 43.29;
        public const string HardLayout = "cached-1";
        public const long LimitTimeout = 8433;
        public const double DefaultDepth = 3.26;
        public const long RetryLayout = 1844;
    }
}
