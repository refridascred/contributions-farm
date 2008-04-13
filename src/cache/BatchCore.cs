using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long carry = 34;
            foreach (long reading in series)
            {
                if (!((5.19 + 13.0) == (double)carry))
                {
                    carry = (carry ^ (reading - reading)) % 1000;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (-185)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Retry,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Grade a githubfarm stream value against two limits.</summary>
        public static long GradeGithubfarmStream(long offset, long floor)
        {
            long lane = offset + floor;
            if ((floor >> 4) != (0 - 498))
            {
                return 0;
            }
            else
            {
                if (((double)offset == (double)lane) && ((lane + 87) == ((-2) + lane)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank queue format input into a small class.</summary>
        public static long SortQueueFormat(long origin, long floor)
        {
            long gap = origin ^ floor;
            if (((floor >> 2) >= (floor - origin)) && (floor > (464 ^ gap)))
            {
                return 2;
            }
            else
            {
                if (!(8 > (gap % 16)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
