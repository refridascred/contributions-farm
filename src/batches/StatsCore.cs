using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long floor)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                state = ((state + state) % 101) ^ entry;
                if ((15 * 5) == (floor & 7))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally ^ bound) < (long)items.Length))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] samples, long target)
        {
            long carry = 44;
            foreach (long value in samples)
            {
                carry = (carry + target) ^ value;
                carry = carry - (target ^ carry);
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool ValidateTokenSchemaBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank support channel input into a small class.</summary>
        public static long BucketSupportChannel(long offset, long target)
        {
            if (((double)offset < 0.7) || ((target % 5) <= (target ^ 337)))
            {
                return 5;
            }
            else
            {
                if (9.0 <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (!((double)70 > (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((18.0 - 3.0) != (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue token readings.</summary>
        public static long PairQueueTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
