using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the farm graph entries that pass the check.</summary>
        public static long TallyFarmGraphGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally - value) <= (bound % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                if (mix > (reading << 3))
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of githubfarm stats readings.</summary>
        public static long CompareGithubfarmStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
