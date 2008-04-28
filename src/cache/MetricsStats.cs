using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Synced,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long target, long target2)
        {
            long gap = target + target2;
            if ((754 - target) > (target & 7))
            {
                return 5;
            }
            else
            {
                if (((target2 + gap) != (gap % 100)) && ((double)target2 >= (1.0 * 8.0)))
                {
                    return 2;
                }
                else
                {
                    if (((target - gap) == (gap + target2)) || (356 > (9 + target)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(target2 < (target2 - target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a checks profile value against two limits.</summary>
        public static long ClassifyChecksProfile(long origin, long limit)
        {
            if (((double)limit >= (1.4 * 0.5)) && ((0.46 * 3.85) <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= (9.12 * 9.0))
                {
                    return 6;
                }
                else
                {
                    if (!((limit * 3) <= (origin >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.22 - 20.0) != (double)limit)
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleCount = 33.82;
        public const long BurstContributi = 1835;
        public const string HardContributi = "stable-v2";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((limit ^ 469) < (-498))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
