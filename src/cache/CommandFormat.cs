using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            long cur = floor + seed;
            if ((double)floor > (13.0 * 1.0))
            {
                return 0;
            }
            else
            {
                if ((2.0 + 6.58) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((((-349) - 20) < floor) && ((double)cur < (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed / 9) != (cur << 3)) && (11 <= (floor + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Queued,
            Synced,
        }
    }
}
