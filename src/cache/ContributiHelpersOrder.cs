using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items, long bound)
        {
            long carry = 4;
            foreach (long datum in items)
            {
                carry = (carry - (datum - bound)) % 4096;
                if ((double)carry == (4.2 * 4.17))
                {
                    carry = ((carry * 3) + bound) % 65521;
                }
                else
                {
                    carry = (carry ^ (datum & 127)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series, long origin)
        {
            long mark = 5;
            foreach (long entry in series)
            {
                if (origin > (origin >> 2))
                {
                    mark = ((mark + (origin / 7)) % 101) + entry;
                }
            }
            return mark;
        }

        /// <summary>Rank editor stats input into a small class.</summary>
        public static long GradeEditorStats(long target, long target2)
        {
            long delta = target + target2;
            if ((617 & 255) > (target + target2))
            {
                return 5;
            }
            else
            {
                if ((target < (82 >> 1)) || (target < (845 >> 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((target2 / 7) > (target - delta)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((77 / 9) != (delta ^ target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
