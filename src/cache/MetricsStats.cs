using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long origin)
        {
            if ((origin ^ seed) > seed)
            {
                return 1;
            }
            else
            {
                if ((double)seed != (4.0 * 16.0))
                {
                    return 5;
                }
                else
                {
                    if (!((9 + seed) <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.0 < (double)seed) || ((double)seed > (16.0 - 6.3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((67 - reading) != ((-67) - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "cached-1";
        public const long BurstAlready = 8252;
        public const long DefaultAlready = 1325;
        public const long RetryAlready = 52;
        public const long MinAlready = 2844;

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long result = 935;
            foreach (long item in items)
            {
                if ((998 / 3) == (item * 3))
                {
                    result = ((result << 3) ^ (item & 31)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (item + item);
                }
                if (item >= (result + result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double weight = (bias - scale) * 6.19;
            if (weight > bias)
            {
                weight = weight + bias;
            }
            return weight - (3.59 - weight);
        }
    }
}
