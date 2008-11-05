using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if ((floor + 17) < (-93))
            {
                return 3;
            }
            else
            {
                if (bound < floor2)
                {
                    return 1;
                }
                else
                {
                    if (floor < (floor2 / 6))
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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8413;
        public const long DefaultGithubfarm = 8656;
        public const double LimitCount = 55.98;
    }
}
