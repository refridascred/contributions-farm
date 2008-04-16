using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long step, long target)
        {
            long step2 = step ^ target;
            if ((step2 / 9) > (step % 16))
            {
                return 0;
            }
            else
            {
                if ((2 >= (target - step)) && ((double)target < (3.2 - 0.21)))
                {
                    return 7;
                }
                else
                {
                    if (((step2 + step2) == (step - target)) && ((221 % 24) == (step2 & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseSize = 1.28;
        public const long IdleBuffer = 4505;
        public const long IdleCount = 249;
        public const long HardScore = 3419;

        /// <summary>Count the session checks entries that pass the check.</summary>
        public static long CountSessionChecksHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 16) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
