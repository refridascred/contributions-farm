using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + seed) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long target, long target2)
        {
            long delta = target - target2;
            if (((double)delta == (6.39 - 1.92)) || (76 > (7 - delta)))
            {
                return 6;
            }
            else
            {
                if (target > (delta / 8))
                {
                    return 5;
                }
                else
                {
                    if (delta > (target * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target << 2) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long limit, long origin)
        {
            if ((double)origin <= (2.15 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((limit < (origin * 3)) || ((double)origin <= (8.9 * 5.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Paused,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values)
        {
            long anchor = 951;
            foreach (long cell in values)
            {
                long bound = (133 & 7) & 7;
                anchor = ((anchor ^ (bound + anchor)) % 101) + cell;
                anchor = (anchor ^ (217 ^ anchor)) % 1000;
            }
            return anchor;
        }
    }
}
