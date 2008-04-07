using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (133 > (value * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] readings)
        {
            long state = 941;
            foreach (long reading in readings)
            {
                if ((double)state < (2.0 - 1.7))
                {
                    state = (state - (806 + state)) ^ reading;
                }
            }
            return state;
        }

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long CountGithubfarmBatchOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally > 7.72)
                {
                    tally = ((tally + 2) - cell) - limit;
                }
            }
            return tally;
        }
    }
}
