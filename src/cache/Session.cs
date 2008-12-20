using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long total = 810;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total - (total * 5)) ^ (long)i;
                }
                if (((datum & 1) <= (datum - (long)samples.Length)) && ((double)total >= (3.95 / 4.0)))
                {
                    total = (total - (datum + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4492;
        public const long MaxScore = 1059;
        public const long SoftBuffer = 396;
        public const double StepFactor = 78.67;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (8.8 / 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
