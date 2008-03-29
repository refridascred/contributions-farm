using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items)
        {
            long result = 48;
            foreach (long cell in items)
            {
                if (656 >= (result & 1))
                {
                    result = (result ^ (cell % 100)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a format counter value against two limits.</summary>
        public static long BucketFormatCounter(long origin, long step)
        {
            if (step <= (step ^ origin))
            {
                return 5;
            }
            else
            {
                if ((5 + origin) == (step * 2))
                {
                    return 0;
                }
                else
                {
                    if (((origin + 322) <= (origin + step)) || (origin < (175 / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin - step) <= (origin >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long origin)
        {
            if ((30 * 3) == (339 + step))
            {
                return 4;
            }
            else
            {
                if ((8.19 / 7.0) > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = 73;
            foreach (long value in levels)
            {
                if ((double)value == (double)sum)
                {
                    sum = ((sum * 5) + (long)levels.Length) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 731)
            {
                sum = (sum - (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }
    }
}
