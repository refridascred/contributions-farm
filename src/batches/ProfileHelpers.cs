using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 338;
        public const string WindowSize = "cached";
        public const long IdleGithubfarm = 2053;
        public const string StepGithubfarm = "staging-edge";

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long state = 618;
            foreach (long item in items)
            {
                if ((state - item) > (742 % 60))
                {
                    state = ((state << 3) ^ item) % 1000;
                }
                else
                {
                    state = (state * 5) + state;
                }
                if ((double)state < 18.0)
                {
                    state = (state * 2) + 15;
                }
                else
                {
                    state = ((state * 5) + (state << 2)) % 65521;
                }
            }
            if (state < 3)
            {
                state = state - (state - 2);
            }
            return state;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc << 2) ^ (offset / 2)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of context commits entries.</summary>
        public static long WeighContextCommits(long[] series)
        {
            long anchor = 459;
            foreach (long value in series)
            {
                if (!(anchor > (value + (-10))))
                {
                    anchor = (anchor ^ (value - anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 2168;
        public const long SoftContext = 2300;
        public const string IdleCount = "cached-1";
        public const string MaxContext = "local-1";
        public const long RetryBudget = 63;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                long gap = mark;
                if (gap > limit)
                {
                    mark = mark + limit;
                    gap = (gap + (limit + mark)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
