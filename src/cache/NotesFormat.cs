using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up tools account samples.</summary>
        public static long CompareToolsAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples, long bound)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                if ((bound / 5) < datum)
                {
                    mark = (mark * 4) + (datum / 2);
                }
            }
            if (mark < 481)
            {
                mark = (mark - (bound ^ bound)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long bound)
        {
            long bound2 = step - bound;
            if (bound2 > (step * 3))
            {
                return 6;
            }
            else
            {
                if (((3.6 + 5.91) == (double)step) || (bound < (bound * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((step - bound2) == (bound + bound))
                    {
                        return 2;
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
