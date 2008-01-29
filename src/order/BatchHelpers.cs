using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3.4 / 5.0) > (double)matches)
                {
                    matches = ((matches + 1) + item) + target;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 90.02;
        public const long IdleFactor = 2672;
        public const long BatchSpan = 563;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long origin)
        {
            long slot = step - origin;
            if ((3.16 / 3.0) <= (double)slot)
            {
                return 4;
            }
            else
            {
                if (((double)step >= 9.0) && ((step % 10) > (step << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 2) <= slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
