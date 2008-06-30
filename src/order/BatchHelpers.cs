using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepScore = "open";
        public const double MinFactor = 33.25;
        public const double BatchTimeout = 34.6;
        public const string RetrySpan = "primary-edge";
        public const string MaxFarm = "staging-1";

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long origin)
        {
            if (((9.14 / 2.0) >= (double)origin) || ((double)limit == (2.1 - 7.4)))
            {
                return 5;
            }
            else
            {
                if ((origin < (origin >> 4)) && ((origin * 4) == (471 * 5)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
