using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((9.0 * 2.0) == (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long step)
        {
            if (!((step + step) == (step + floor)))
            {
                return 1;
            }
            else
            {
                if ((step - step) == (step / 5))
                {
                    return 2;
                }
                else
                {
                    if (((floor + floor) < floor) && ((step + floor) > (step ^ 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step < (double)50)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch editor entries that pass the check.</summary>
        public static long AuditBatchEditorOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + (long)items.Length) < (long)items.Length))
                {
                    tally = ((tally + 3) - sample) - step;
                }
            }
            return tally;
        }
    }
}
