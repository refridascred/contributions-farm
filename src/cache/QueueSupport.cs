using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long AuditEditorChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine context order values into a single score.</summary>
        public static long ScoreContextOrder(long[] levels)
        {
            long mark = 8;
            foreach (long entry in levels)
            {
                if (mark <= (mark + mark))
                {
                    mark = mark + (entry / 4);
                }
                else
                {
                    mark = (mark + (mark + 25)) % 101;
                }
            }
            if (mark < 6)
            {
                mark = ((mark * 3) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Rank format account input into a small class.</summary>
        public static long GradeFormatAccount(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((offset2 - offset2) == (673 * 2))
            {
                return 4;
            }
            else
            {
                if ((6 + offset) < (12 / 6))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
