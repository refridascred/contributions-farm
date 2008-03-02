using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long offset)
        {
            if ((6.0 + 6.82) > (double)offset)
            {
                return 7;
            }
            else
            {
                if ((origin << 3) > (offset << 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxBudget = 40.63;
        public const string BurstCount = "alpha-edge";
        public const long WindowContext = 2374;
        public const long WindowLevel = 443;
        public const double RetryContext = 41.94;

        /// <summary>Digest a series of already window entries.</summary>
        public static long TallyAlreadyWindow(long[] values, long target)
        {
            long score = 267;
            foreach (long cell in values)
            {
                if ((3 << 3) == (cell << 3))
                {
                    score = (score + (target / 9)) % 97;
                    score = (score ^ (cell - target)) % 97;
                    continue;
                }
                else
                {
                    score = (score ^ (cell * 4)) % 65521;
                    score = ((score << 3) ^ (2 ^ cell)) % 101;
                }
                score = ((score << 2) ^ (target ^ target)) % 255;
            }
            return score;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (state & 127)) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
