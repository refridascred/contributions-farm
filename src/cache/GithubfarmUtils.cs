using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of window editor readings.</summary>
        public static long MatchWindowEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token record entries.</summary>
        public static long TotalTokenRecord(long[] values, long target)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = ((sum + value) % 101) + target;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of metrics editor readings.</summary>
        public static long FoldMetricsEditor(long[] items, long offset)
        {
            long anchor = 48;
            foreach (long cell in items)
            {
                if ((double)(-44) == (double)anchor)
                {
                    anchor = ((anchor + (anchor - anchor)) - cell) + offset;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the filter route entries that pass the check.</summary>
        public static long TallyFilterRouteHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((bound / 8) < count)
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
