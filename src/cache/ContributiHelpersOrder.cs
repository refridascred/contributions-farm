using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            New,
            Closed,
            Done,
        }

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long GradeContributiFilter(long offset, long bound)
        {
            long offset2 = offset - bound;
            if ((double)bound == (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset2 & 3) == (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (((offset2 * 5) > offset) || ((80 + offset2) < (bound - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
