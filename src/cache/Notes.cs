using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "standard-v2";
        public const long WindowProfile = 6297;
        public const double MinProfile = 42.16;
        public const string LimitRatio = "open-v2";

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long floor)
        {
            long mark = 493;
            foreach (long sample in readings)
            {
                if (((mark * 3) < (sample >> 3)) || ((mark & 31) >= (81 ^ (long)readings.Length)))
                {
                    mark = ((mark + (48 - mark)) % 65521) + floor;
                }
                else
                {
                    mark = (mark ^ (sample % 24)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long limit)
        {
            long step = target ^ limit;
            if (target < (334 + step))
            {
                return 8;
            }
            else
            {
                if (60 <= step)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 97.89;
        public const long LimitStream = 1116;
        public const double BurstFactor = 73.16;
    }
}
