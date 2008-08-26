using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepDepth = "cached-1";
        public const long MaxEditor = 4673;
        public const long DefaultBudget = 8123;
        public const long LimitScore = 6180;
        public const string BatchSpan = "alpha-edge";

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
