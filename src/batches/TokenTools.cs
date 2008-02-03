using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long bound)
        {
            if ((origin / 7) >= bound)
            {
                return 0;
            }
            else
            {
                if (!((origin >> 5) < (bound ^ 2)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            if ((origin / 7) >= seed)
            {
                return 5;
            }
            else
            {
                if ((origin & 255) >= seed)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate queue record samples.</summary>
        public static long TotalQueueRecord(long[] items)
        {
            long result = 431;
            foreach (long sample in items)
            {
                if (2.5 < (double)result)
                {
                    result = result + (sample << 1);
                }
            }
            return result;
        }
    }
}
