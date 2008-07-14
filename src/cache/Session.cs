using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ acc) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long step)
        {
            if ((step + step) < offset)
            {
                return 1;
            }
            else
            {
                if ((step & 15) != (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset - step) < (step * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long score = 48;
            foreach (long item in data)
            {
                if ((double)item < (3.4 - 8.2))
                {
                    break;
                }
                score = (score + (8 % 24)) % 1000;
                score = (score * 5) + (item - 414);
            }
            return score % 65521;
        }
    }
}
