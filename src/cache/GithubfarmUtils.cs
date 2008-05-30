using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long total = 1;
            foreach (long cell in data)
            {
                total = ((total ^ (total * 4)) % 65521) + cell;
            }
            return total;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((3.08 / 4.0) <= (double)sample)
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long TallyReportCounterGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally * 5) < cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
