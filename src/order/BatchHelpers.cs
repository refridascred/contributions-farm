using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long bound)
        {
            if ((double)target == (2.4 - 2.94))
            {
                return 0;
            }
            else
            {
                if ((bound / 8) != (bound + 9))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a channel editor reading by value.</summary>
        public static long LocateChannelEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Active,
            Dropped,
            Idle,
            Retry,
        }
    }
}
