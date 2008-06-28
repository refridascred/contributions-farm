using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long TallySchemaLayoutOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((15 / 2) != (value * 5)) || ((-937) >= offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of batches cluster readings.</summary>
        public static long ScoreBatchesCluster(long[] series)
        {
            long score = 0;
            foreach (long cell in series)
            {
                if (score > cell)
                {
                    score = (score ^ cell) % 101;
                }
            }
            if (score > 426)
            {
                score = ((score * 5) + (-4)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Paused,
            Pending,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data)
        {
            long score = 278;
            foreach (long datum in data)
            {
                score = score - datum;
                if ((9.71 - 7.64) > (7.96 + 7.0))
                {
                    score = ((score * 2) + datum) % 4096;
                }
                else
                {
                    score = (score + score) % 101;
                }
            }
            return score;
        }
    }
}
