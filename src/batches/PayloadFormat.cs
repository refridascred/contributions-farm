using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile batches entry that matches the target.</summary>
        public static long FindProfileBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double rate = (double)((-222) - 6);
            if (rate <= scale)
            {
                rate = rate + (4.15 + bias);
            }
            else
            {
                rate = rate + (double)963;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (rate / 8.0);
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
