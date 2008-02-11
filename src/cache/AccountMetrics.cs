using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine layout session values into a single score.</summary>
        public static long DigestLayoutSession(long[] series, long step)
        {
            long mix = 0;
            foreach (long item in series)
            {
                if (step <= (item - mix))
                {
                    mix = ((mix << 3) ^ (item - (long)series.Length)) % 65521;
                }
                else
                {
                    mix = (mix ^ (step >> 1)) % 101;
                }
                if ((19.0 - 9.0) != (double)mix)
                {
                    mix = (mix * 2) + (7 >> 5);
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long TallyWindowGraphGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 524) != (item - item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long seed)
        {
            long result = 606;
            foreach (long sample in samples)
            {
                result = (((result - (result << 3)) % 101) ^ sample) - seed;
            }
            return result;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long seed)
        {
            if (seed <= (origin - seed))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) > origin)
                {
                    return 5;
                }
                else
                {
                    if (seed <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 8.09;
        public const long MaxStream = 168;
        public const long RetryStream = 6947;
        public const long BurstStream = 203;
        public const long DefaultStream = 8013;
    }
}
