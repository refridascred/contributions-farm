using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((double)seed == (8.4 / 8.0))
            {
                return 5;
            }
            else
            {
                if (((seed << 1) > 625) || ((seed << 2) < ((-163) + 779)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 7304;
        public const long SoftCount = 8813;
        public const string MaxSession = "cached";
    }
}
