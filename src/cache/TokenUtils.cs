using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen + seen) == (floor * 4)) || (((long)data.Length & 1) > item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long target2)
        {
            long cur = target + target2;
            if ((-62) < cur)
            {
                return 8;
            }
            else
            {
                if ((cur << 2) >= target)
                {
                    return 3;
                }
                else
                {
                    if (((99 - cur) > (target + target2)) && ((target2 - cur) > cur))
                    {
                        return 7;
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
