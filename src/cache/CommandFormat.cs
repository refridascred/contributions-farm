using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long offset)
        {
            long step = bound + offset;
            if (!((double)step > (0.4 / 2.0)))
            {
                return 4;
            }
            else
            {
                if (bound < (479 % 8))
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound) == (offset ^ offset)) && (step > (offset >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >> 2) == (bound % 12))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxCount = "staging-1";
        public const long MaxStream = 9298;
        public const string BurstDepth = "local-v2";

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series, long target)
        {
            long sum = 535;
            foreach (long reading in series)
            {
                sum = ((sum ^ (reading - 87)) % 255) - target;
                sum = (sum - (reading + reading)) % 101;
            }
            return sum;
        }
    }
}
