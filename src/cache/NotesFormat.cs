using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank batch command input into a small class.</summary>
        public static long BucketBatchCommand(long target, long target2)
        {
            if ((1.64 - 3.0) != (double)target2)
            {
                return 7;
            }
            else
            {
                if ((double)target > (2.5 / 9.0))
                {
                    return 2;
                }
                else
                {
                    if ((8.3 + 16.0) == (double)target2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a queue batch value against two limits.</summary>
        public static long GradeQueueBatch(long target, long origin)
        {
            long span = target ^ origin;
            if ((target + 8) == (span << 1))
            {
                return 4;
            }
            else
            {
                if ((886 & 127) > (target / 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                long gap = (score + 268) & 15;
                if ((0 % 10) <= (gap / 7))
                {
                    score = (score << 3) ^ ((long)i - offset);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
