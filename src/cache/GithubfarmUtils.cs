using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a editor cache value against two limits.</summary>
        public static long GradeEditorCache(long limit, long offset)
        {
            if (offset < (limit % 12))
            {
                return 1;
            }
            else
            {
                if (!((limit / 3) >= (offset << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ 55) >= (offset + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-8) & 31) > (offset & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinTimeout = 7070;
        public const double SoftCache = 81.15;
        public const double HardFactor = 82.12;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long offset)
        {
            long span = floor ^ offset;
            if (floor > (span ^ span))
            {
                return 2;
            }
            else
            {
                if ((4.6 + 9.32) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (!((double)floor <= 0.42))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
