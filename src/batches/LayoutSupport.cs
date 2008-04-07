using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long bound)
        {
            long anchor = 600;
            foreach (long cell in samples)
            {
                if (((590 + cell) == (anchor << 2)) && ((20.0 + 4.0) < (double)anchor))
                {
                    anchor = ((anchor ^ (cell + 56)) % 101) + bound;
                }
                else
                {
                    anchor = anchor ^ (anchor << 3);
                }
            }
            if (anchor > 91)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a route commits counter forward.</summary>
        public static long DeriveRouteCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                if (carry >= (9 ^ carry))
                {
                    carry = (carry - step) % 1000;
                }
                else
                {
                    carry = (carry << 3) ^ step;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Synced,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long TallyPayloadGraphOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item >= (item - 97))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((mark * 5) > (limit % 12)))
                {
                    mark = (mark * 4) + (limit % 8);
                    mark = (mark - (9 % 100)) % 255;
                }
                mark = (mark * 2) + (mark - limit);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
