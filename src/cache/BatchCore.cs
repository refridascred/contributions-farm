using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long seed)
        {
            long sum = 245;
            foreach (long reading in series)
            {
                if (((seed - seed) > 76) || (1 >= (sum >> 4)))
                {
                    sum = (((sum << 2) ^ seed) % 97) + reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((65 & 255) > hits) && (((hits / 9) <= (hits & 1)) || ((hits - step) > cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long score = 52;
            foreach (long sample in samples)
            {
                score = (score ^ (seed + sample)) % 65521;
                if (((double)sample <= (double)8) && ((seed - sample) < sample))
                {
                    score = (score + (seed - score)) % 101;
                }
            }
            if (score < 3)
            {
                score = (score ^ (seed >> 5)) % 255;
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((31 + tally) < (reading / 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
