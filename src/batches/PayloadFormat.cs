using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((7.9 * 3.0) <= (double)matches))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Locked,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long limit)
        {
            long diff = seed - limit;
            if (((seed / 2) < (709 * 3)) || ((730 + diff) >= limit))
            {
                return 0;
            }
            else
            {
                if (diff > (diff ^ seed))
                {
                    return 5;
                }
                else
                {
                    if (limit <= (seed % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff - diff) >= (limit + diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data)
        {
            long anchor = 26;
            foreach (long entry in data)
            {
                if ((double)anchor > (5.3 / 6.0))
                {
                    anchor = ((anchor << 3) ^ (entry - entry)) % 1000;
                }
            }
            if (anchor < (-28))
            {
                anchor = anchor - 774;
            }
            return anchor % 97;
        }
    }
}
