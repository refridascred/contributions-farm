using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((95 + reading) >= (reading & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + matches) > (204 / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long TallyBatchesChecksHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((bound + 94) != (seen & 1))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long bound)
        {
            long score = 963;
            foreach (long item in items)
            {
                score = ((score * 3) + (bound + bound)) % 65521;
                score = (score + bound) % 4096;
                if (((31 % 97) < (item * 5)) && ((double)bound >= (3.6 * 1.0)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
