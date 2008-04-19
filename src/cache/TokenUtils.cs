using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload batches entries that pass the check.</summary>
        public static long AuditPayloadBatchesMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) <= (36 / 9))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long step)
        {
            long gap = origin - step;
            if ((step * 5) < (2 - 82))
            {
                return 8;
            }
            else
            {
                if (((4.0 / 7.0) > (double)step) || ((59 << 2) > (gap - gap)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (double)gap)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step + gap) >= step) && ((10.0 * 7.0) > (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
