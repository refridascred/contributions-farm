using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score * 3) + (score + 2);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 5798;
        public const string IdleSize = "strict-v2";
        public const string BaseChecks = "legacy";
        public const long StepChecks = 2192;

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = state + (state >> 2);
                if ((double)state == (double)offset)
                {
                    state = (state << 2) ^ (offset << 2);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long limit)
        {
            long step = target ^ limit;
            if (target < (334 + step))
            {
                return 8;
            }
            else
            {
                if (60 <= step)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
