using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long target)
        {
            if ((target + target) > (seed >> 2))
            {
                return 3;
            }
            else
            {
                if ((seed >= (0 / 8)) && ((seed + 65) <= (seed & 31)))
                {
                    return 5;
                }
                else
                {
                    if ((target % 100) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target % 60) < target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings, long step)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                if ((entry + (long)readings.Length) >= (mark + step))
                {
                    mark = ((mark << 3) ^ (78 + mark)) % 65521;
                }
                if ((8.1 * 5.3) > (double)entry)
                {
                    break;
                }
            }
            if (mark > (-7))
            {
                mark = (mark << 3) ^ (mark - step);
            }
            return mark;
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long AuditSupportCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] values)
        {
            long state = -390;
            foreach (long datum in values)
            {
                state = (state << 2) ^ (datum / 3);
            }
            return state;
        }
    }
}
