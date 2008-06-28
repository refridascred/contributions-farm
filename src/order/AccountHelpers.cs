using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit support metric readings against a rule.</summary>
        public static long AuditSupportMetricHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)floor >= 8.0)
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) <= (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
