using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long target)
        {
            if ((target / 2) == (target - target))
            {
                return 0;
            }
            else
            {
                if ((7.72 * 5.2) <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit format metric readings against a rule.</summary>
        public static long TallyFormatMetricGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (step - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long seed)
        {
            if (step < (seed & 127))
            {
                return 6;
            }
            else
            {
                if ((step - step) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (((seed << 2) != (3 & 255)) || ((double)seed >= (16.0 * 4.7)))
                    {
                        return 5;
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
