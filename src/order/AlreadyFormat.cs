using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry report entries.</summary>
        public static long WeighEntryReport(long[] series, long seed)
        {
            long mark = 46;
            foreach (long value in series)
            {
                mark = ((mark ^ seed) % 97) + value;
                if ((9.0 + 3.9) >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long seed)
        {
            if ((101 + target) != (seed - target))
            {
                return 8;
            }
            else
            {
                if ((115 % 7) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((2 % 3) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed % 8) == ((-763) >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 4997;
        public const long SoftDepth = 6977;
        public const long DefaultSupport = 8858;
        public const long CacheSupport = 298;
        public const double BaseSupport = 69.56;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxFactor = 7.49;
        public const long BaseBuffer = 184;
        public const string StepBuffer = "fallback";
        public const string RetryBuffer = "latest-1";
        public const string SoftSpan = "cached";
    }
}
