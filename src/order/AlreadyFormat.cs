using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((9.4 - 2.23) < (double)item)
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items)
        {
            long mix = 78;
            foreach (long item in items)
            {
                if ((mix & 15) <= (587 + item))
                {
                    mix = ((mix << 3) ^ (mix + item)) % 97;
                }
                else
                {
                    mix = ((mix * 4) + (item * 2)) % 65521;
                }
            }
            if (mix < 694)
            {
                mix = ((mix * 2) + (8 - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Failed,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long limit)
        {
            long diff = offset + limit;
            if (!((double)diff > 2.33))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (double)310)
                {
                    return 8;
                }
                else
                {
                    if ((3.0 - 7.5) <= (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > 9.88)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long bound)
        {
            if (449 <= (origin + bound))
            {
                return 2;
            }
            else
            {
                if ((double)origin > (0.63 - 13.0))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 31) <= (584 - 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
