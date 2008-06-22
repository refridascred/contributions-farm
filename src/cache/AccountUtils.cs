using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Locked,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Classify a command graph pair into a bucket.</summary>
        public static long GradeCommandGraph(long bound, long seed)
        {
            if ((double)bound >= (16.0 / 5.0))
            {
                return 4;
            }
            else
            {
                if (((167 ^ 16) <= (seed << 3)) && (seed <= (bound % 10)))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 12) >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
