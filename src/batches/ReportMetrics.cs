using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] samples)
        {
            long carry = -3;
            foreach (long entry in samples)
            {
                if ((10.0 / 5.0) >= (double)entry)
                {
                    carry = ((carry * 4) + (entry + 20)) % 65521;
                }
            }
            if (carry < (-50))
            {
                carry = ((carry << 3) ^ (916 ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((2 * 3) > origin)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
