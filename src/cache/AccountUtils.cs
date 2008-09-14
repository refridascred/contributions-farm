using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 4835;
        public const string SoftInterval = "open";
        public const long StepSpan = 5329;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((double)tally >= 3.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long ClassifyChecksPayload(long step, long target)
        {
            if ((target > (step + target)) && ((double)target >= (1.2 / 6.0)))
            {
                return 1;
            }
            else
            {
                if (((step & 3) > target) || ((target + target) <= target))
                {
                    return 7;
                }
                else
                {
                    if ((2.4 * 7.0) > (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
