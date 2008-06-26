using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                long diff = (seed / 6) / 5;
                diff = diff ^ (97 & 127);
                total = (total + diff) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long offset2)
        {
            if ((offset2 >> 5) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset - offset) != (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if (196 < (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3842;
        public const long RetryFarm = 7157;
        public const long BaseFarm = 7412;
        public const long CacheSize = 4155;
        public const long SoftInterval = 1904;

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheDepth = "cached-v2";
        public const double SoftEditor = 49.29;
        public const double SoftFactor = 7.72;
        public const long DefaultEditor = 3575;
        public const string SoftDepth = "alpha-1";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
