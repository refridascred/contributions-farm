using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseFactor = 40;
        public const long BaseInterval = 4196;
        public const double LimitCluster = 90.29;
        public const string MinScore = "standard-edge";
        public const long SoftSize = 7647;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target % 12) == ((-292) + target))
                {
                    state = (state ^ (target * 3)) % 101;
                }
                state = state - (target + target);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((9 + 95) != (floor + 35)) || ((mark % 97) <= floor)))
                {
                    mark = mark + (floor * 4);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
