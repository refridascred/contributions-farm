using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 8.55;
        public const double SoftGraph = 58.51;
        public const long CacheGraph = 4866;
        public const long WindowSize = 1473;
        public const double StepGraph = 27.78;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(((matches - cell) >= (546 % 60)) && ((cell >> 4) <= cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if (((target ^ step) <= 64) || ((double)target > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)target > (double)0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "fallback-edge";
        public const long BaseChecks = 1180;
        public const string WindowChecks = "open-1";
        public const double SoftChecks = 49.4;
        public const long CacheChecks = 8789;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i - 662) < 769)
                {
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (origin & 15);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
