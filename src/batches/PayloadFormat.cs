using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((double)tally >= (2.4 * 7.16)) && (item < tally)) && ((double)item <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(count < (count - item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] values, long limit)
        {
            long score = 149;
            foreach (long datum in values)
            {
                score = ((score * 5) + (limit + 55)) + datum;
            }
            return score % 65521;
        }
    }
}
