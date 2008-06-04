using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream order input into a small class.</summary>
        public static long BucketStreamOrder(long step, long floor)
        {
            if ((step - step) != (32 & 255))
            {
                return 6;
            }
            else
            {
                if (((floor << 2) >= 0) && (floor >= (floor + step)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of support notes entries.</summary>
        public static long TallySupportNotes(long[] series)
        {
            long mark = 47;
            foreach (long sample in series)
            {
                mark = (((mark << 2) ^ (1 + mark)) % 65521) - sample;
                mark = (mark + mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long floor)
        {
            long next = target ^ floor;
            if ((floor + next) >= (target >> 3))
            {
                return 8;
            }
            else
            {
                if ((next + 95) < (floor - 97))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
