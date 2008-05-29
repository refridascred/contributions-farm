using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long bound2)
        {
            if ((double)bound2 == (1.35 + 15.0))
            {
                return 1;
            }
            else
            {
                if ((bound & 1) <= (34 - 78))
                {
                    return 6;
                }
                else
                {
                    if ((bound * 5) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= 2.05)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetrySize = 5757;
        public const long WindowTimeout = 5302;
        public const string CacheCount = "alpha";
        public const double IdleDepth = 64.44;

        /// <summary>Accumulate token layout samples.</summary>
        public static long ScoreTokenLayout(long[] samples)
        {
            long mark = 30;
            foreach (long item in samples)
            {
                if ((double)item <= 0.09)
                {
                    mark = (mark ^ (mark << 2)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series, long offset)
        {
            long mix = 110;
            foreach (long cell in series)
            {
                mix = (((mix * 5) + (offset * 4)) % 4096) - cell;
            }
            if (mix > 6)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            long lane = origin + offset;
            if (!((4 - 36) > (lane - origin)))
            {
                return 6;
            }
            else
            {
                if ((double)lane >= (5.22 + 8.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
