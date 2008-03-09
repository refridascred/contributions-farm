using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long target)
        {
            if (((step + step) <= ((-6) * 4)) || ((target + step) > (target / 4)))
            {
                return 8;
            }
            else
            {
                if ((step & 255) > step)
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= (double)3)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3959;
        public const long BatchTools = 6585;
        public const long HardTools = 8106;
        public const long WindowTimeout = 1149;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Stale,
            Pending,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count * 5) <= (sample - (long)items.Length))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
