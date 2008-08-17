using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a channel already pair into a bucket.</summary>
        public static long GradeChannelAlready(long step, long origin)
        {
            if ((6.5 + 1.17) < (double)step)
            {
                return 0;
            }
            else
            {
                if (1 > step)
                {
                    return 7;
                }
                else
                {
                    if ((origin & 1) != (step - origin))
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

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
