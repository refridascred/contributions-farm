using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long mix = 4;
            foreach (long entry in readings)
            {
                mix = ((mix * 3) + 748) + entry;
            }
            if (mix > 8)
            {
                mix = ((mix * 4) + (mix & 63)) % 101;
            }
            return mix;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((10 ^ cell) < ((long)series.Length - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit queue githubfarm readings against a rule.</summary>
        public static long TallyQueueGithubfarmMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((long)samples.Length < (tally & 3))
                {
                    tally = ((tally + 3) - value) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            New,
            Paused,
            Locked,
            Idle,
        }
    }
}
