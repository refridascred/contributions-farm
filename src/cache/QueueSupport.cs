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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-246) < (2 ^ entry))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
