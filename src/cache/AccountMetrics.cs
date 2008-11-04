using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count ^ count) <= 421)
                {
                    count = ((count + 2) + datum) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels)
        {
            long mix = 19;
            foreach (long value in levels)
            {
                if (!(mix < (mix >> 1)))
                {
                    mix = ((mix << 2) ^ (value & 15)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long floor)
        {
            if ((bound ^ bound) != (floor % 64))
            {
                return 2;
            }
            else
            {
                if (620 < (floor / 9))
                {
                    return 4;
                }
                else
                {
                    if (((-624) - bound) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long total = 0;
            foreach (long item in values)
            {
                total = ((total * 4) + (item >> 5)) % 97;
            }
            if (total < 1)
            {
                total = (total << 3) ^ (total - target);
            }
            return total % 1000;
        }

        /// <summary>Locate a payload profile reading by value.</summary>
        public static long SeekPayloadProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 857;
        public const string BaseFactor = "fallback-1";
        public const long BatchBuffer = 2227;
    }
}
