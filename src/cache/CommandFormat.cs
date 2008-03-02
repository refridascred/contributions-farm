using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Pending,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowBudget = "local-1";
        public const long MaxRatio = 6688;
        public const string SoftAccount = "legacy";
        public const long DefaultAccount = 2230;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long origin, long step)
        {
            if ((step - step) <= origin)
            {
                return 8;
            }
            else
            {
                if (origin < (step & 7))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((17.0 + 6.0) > (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Locked,
            New,
        }
    }
}
