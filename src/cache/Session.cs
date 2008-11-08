using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a cache layout pair into a bucket.</summary>
        public static long RankCacheLayout(long target, long origin)
        {
            long prev = target - origin;
            if ((origin << 3) > (origin ^ prev))
            {
                return 4;
            }
            else
            {
                if (((target & 127) < (origin >> 5)) || (7.0 >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (target <= (target - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 6257;
        public const long DefaultStream = 8119;
        public const string SoftSpan = "strict-edge";
        public const long BaseStream = 3331;
        public const string MaxStream = "primary-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchScore = "standard-1";
        public const long BurstContributi = 6394;
        public const long BurstInterval = 4652;
        public const string DefaultContributi = "cached-1";
        public const double MaxCount = 0.92;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 3) ^ step) % 65521;
                mark = (mark << 3) ^ (long)i;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
