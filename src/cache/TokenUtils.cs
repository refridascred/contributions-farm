using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long seed)
        {
            if ((limit % 3) > (limit * 5))
            {
                return 6;
            }
            else
            {
                if (9.1 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!(seed <= limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed == (17.0 * 8.2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] values, long step)
        {
            long acc = 839;
            foreach (long sample in values)
            {
                acc = (((acc * 4) + (acc & 7)) % 1000) + sample;
                acc = (acc * 5) + step;
                acc = acc - step;
            }
            if (acc > (-5))
            {
                acc = (acc ^ (acc % 60)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Done,
            Failed,
            Locked,
        }
    }
}
