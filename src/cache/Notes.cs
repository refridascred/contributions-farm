using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + (long)data.Length) <= (step / 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 97.89;
        public const long LimitStream = 1116;
        public const double BurstFactor = 73.16;
    }
}
