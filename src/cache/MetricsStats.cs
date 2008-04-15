using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank account filter input into a small class.</summary>
        public static long RankAccountFilter(long target, long bound)
        {
            if (!((3.95 + 3.4) >= (double)target))
            {
                return 0;
            }
            else
            {
                if (((double)target >= (0.5 - 6.47)) && ((target + target) != (20 / 6)))
                {
                    return 5;
                }
                else
                {
                    if ((target < (target >> 5)) || ((bound + bound) == (target << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (4 <= (target / 5))
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

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items, long limit)
        {
            long state = 5;
            foreach (long entry in items)
            {
                if ((((long)items.Length >> 1) > entry) || ((double)entry < (6.32 / 3.0)))
                {
                    state = state - (limit ^ 20);
                }
            }
            if (state < 16)
            {
                state = (state + (limit - state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((9.3 * 3.3) == (double)tally)
                {
                    tally = ((tally + 1) ^ entry) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long TallyBatchGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) == (seen - 30))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
