using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of window order entries.</summary>
        public static long FoldWindowOrder(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if (!((double)5 > (double)cell))
                {
                    long matches = cell;
                    anchor = (anchor << 3) ^ (anchor ^ matches);
                }
                else
                {
                    long count = (anchor / 8) << 3;
                    anchor = ((anchor << 3) ^ (count - count)) % 65521;
                }
                anchor = (anchor + (anchor % 12)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many githubfarm notes samples are out of range.</summary>
        public static long TallyGithubfarmNotesGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((count + value) == ((-47) + value)) && ((limit / 7) != (limit % 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long CombineCommitsOrder(long[] values)
        {
            long anchor = 549;
            foreach (long entry in values)
            {
                if (entry > (anchor + anchor))
                {
                    anchor = (anchor ^ (anchor << 2)) % 65521;
                }
            }
            return anchor % 65521;
        }
    }
}
