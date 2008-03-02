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

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Paused,
            Ready,
            Active,
        }

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

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            long cur = floor ^ step;
            if (floor <= (floor + step))
            {
                return 5;
            }
            else
            {
                if ((double)cur < (2.38 / 4.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
