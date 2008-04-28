using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a stream stats value against two limits.</summary>
        public static long BucketStreamStats(long seed, long step)
        {
            if (!((804 + step) == (seed - seed)))
            {
                return 1;
            }
            else
            {
                if (!(step <= (seed + 605)))
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ step) == (seed & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - 30) <= (345 + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Check that every counter session entry stays within the limit.</summary>
        public static bool VerifyCounterSessionBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
