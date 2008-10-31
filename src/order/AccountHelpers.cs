using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MinSize = "stable";
        public const double BatchCount = 82.38;
        public const double CacheCommits = 90.74;
        public const string MaxCommits = "stable-1";
        public const long LimitCommits = 3430;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4006;
        public const double MinRatio = 73.63;
        public const string CacheContributi = "cached-v2";
        public const string WindowFactor = "latest-edge";
        public const double SoftRatio = 26.74;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Failed,
            Idle,
            New,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long offset)
        {
            long offset2 = target ^ offset;
            if ((target % 97) > (offset2 - (-30)))
            {
                return 1;
            }
            else
            {
                if ((10.0 + 5.0) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (3.7 * 2.91))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (offset2 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits + floor) == (floor ^ floor)) && (6.3 > (double)sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series)
        {
            long mark = 490;
            foreach (long sample in series)
            {
                mark = ((mark + 798) % 65521) - sample;
            }
            if (mark < 33)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }
    }
}
