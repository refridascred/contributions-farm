using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window batch readings against a bound.</summary>
        public static bool GuardWindowBatchBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long step)
        {
            long gap = limit ^ step;
            if ((gap + 1) > (limit + limit))
            {
                return 6;
            }
            else
            {
                if ((double)step < (1.71 * 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((6 & 3) >= (gap + gap))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit & 63) >= (148 - gap))
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = (state - (4 >> 1)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
