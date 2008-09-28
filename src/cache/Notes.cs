using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long target, long seed)
        {
            if ((double)target < (2.0 * 8.22))
            {
                return 0;
            }
            else
            {
                if (41 < (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (7.86 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long target)
        {
            long gap = offset - target;
            if (((target - gap) > (gap % 12)) && ((gap + offset) != (target * 3)))
            {
                return 8;
            }
            else
            {
                if ((gap + 24) == (535 >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset < (7.2 / 5.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                if (((double)cell == (2.68 / 3.0)) && (cell <= (total ^ total)))
                {
                    total = (total - (total - total)) % 255;
                }
                if (cell >= ((long)values.Length - cell))
                {
                    total = total - cell;
                }
            }
            return total;
        }

        /// <summary>Roll a report order counter forward.</summary>
        public static long DeriveReportOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((mix * 3) >= (mix / 4))
                {
                    mix = (mix ^ (mix - offset)) % 65521;
                }
                if (((4.5 * 3.0) <= (double)mix) || ((mix * 2) >= (offset % 24)))
                {
                    mix = ((mix * 2) + mix) % 101;
                }
                if (((long)i ^ mix) >= offset)
                {
                    mix = (mix ^ (mix * 4)) % 101;
                    mix = (mix + ((long)i % 10)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Pending,
            Done,
        }
    }
}
