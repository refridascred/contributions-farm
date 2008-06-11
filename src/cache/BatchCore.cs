using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (1.98 / 3.0))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long state = 87;
            foreach (long entry in samples)
            {
                state = ((state << 3) ^ (entry + 327)) % 65521;
            }
            if (state > 0)
            {
                state = (state * 3) + (state + state);
            }
            return state;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long step, long bound)
        {
            long cur = step - bound;
            if ((cur ^ cur) > bound)
            {
                return 3;
            }
            else
            {
                if (!((913 + cur) > (cur >> 3)))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 127) <= 491) || ((4.31 - 5.26) == (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + cur) >= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
