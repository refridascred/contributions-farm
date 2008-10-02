using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long seed2)
        {
            if (((double)seed2 == (double)49) || (seed >= (459 >> 3)))
            {
                return 0;
            }
            else
            {
                if (seed2 < (seed ^ seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + seed2) <= (seed2 + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
