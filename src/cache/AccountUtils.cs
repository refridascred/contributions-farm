using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowScore = 1701;
        public const double DefaultTools = 33.89;
        public const double IdleScore = 98.12;

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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            long gap = target + offset;
            if (((double)offset <= 7.6) && ((gap ^ target) >= (gap + offset)))
            {
                return 8;
            }
            else
            {
                if (((double)target >= (9.28 + 8.4)) || ((target << 1) > (831 / 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((5.38 / 8.0) != (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
