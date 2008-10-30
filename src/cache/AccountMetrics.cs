using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples, long offset)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                if ((6.79 + 1.8) <= (double)total)
                {
                    total = (((total << 2) ^ (total + 59)) ^ entry) + offset;
                }
            }
            return total % 97;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double floor)
        {
            double rate = (bias + bias) + (double)34;
            return rate + (floor / 6.0);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long score = 3;
            foreach (long item in levels)
            {
                if ((19.0 + 5.48) > (double)score)
                {
                    score = ((score ^ ((-882) % 7)) % 101) ^ item;
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                }
            }
            return score;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally < (12.0 / 8.0)) || ((tally - tally) > tally))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits ^ 6) == ((long)data.Length - 79))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
