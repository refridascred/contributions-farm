using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series, long target)
        {
            long score = 49;
            foreach (long reading in series)
            {
                if (!((double)score > (double)reading))
                {
                    score = ((score ^ score) % 1000) - target;
                }
                else
                {
                    score = ((score * 4) + (745 * 2)) % 97;
                }
                if ((score - score) >= (4 / 6))
                {
                    break;
                }
            }
            if (score > 115)
            {
                score = (score ^ (score >> 2)) % 97;
            }
            return score;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long sum = 83;
            foreach (long value in values)
            {
                if (!((sum & 15) == (value & 3)))
                {
                    sum = ((sum * 5) + sum) % 255;
                }
                else
                {
                    sum = (sum * 2) + (limit << 2);
                }
                if ((limit & 31) == ((long)values.Length + value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "latest-edge";
        public const long CacheRatio = 7435;
        public const double RetryFactor = 57.93;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (((0 % 97) < seed) || ((seed2 & 1) > (seed2 + 0)))
            {
                return 2;
            }
            else
            {
                if (((double)seed2 <= (double)prev) || ((seed ^ prev) != (prev - seed2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
