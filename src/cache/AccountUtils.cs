using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a schema support pair into a bucket.</summary>
        public static long GradeSchemaSupport(long step, long offset)
        {
            if ((step << 3) <= offset)
            {
                return 5;
            }
            else
            {
                if (!((double)offset > (6.0 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (0 <= (offset >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
