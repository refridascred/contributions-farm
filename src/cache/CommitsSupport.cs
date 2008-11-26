using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long ClassifyChecksCommits(long target, long target2)
        {
            long edge = target + target2;
            if (!((double)target < 3.4))
            {
                return 6;
            }
            else
            {
                if (target > 1)
                {
                    return 1;
                }
                else
                {
                    if ((target2 & 255) < (9 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge & 1) >= ((-4) >> 3))
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

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data)
        {
            long mix = -333;
            foreach (long value in data)
            {
                if (mix < (mix - mix))
                {
                    mix = (mix - (mix + mix)) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (757 - value)) % 97;
                }
            }
            if (mix < (-1))
            {
                mix = (mix - (69 + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((6 >= (count % 5)) && (((item + count) < (count + item)) || (((long)levels.Length / 3) <= (item - count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(matches >= (matches + 70)))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
