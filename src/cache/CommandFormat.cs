using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate format support readings against a bound.</summary>
        public static bool ValidateFormatSupportBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] readings, long limit)
        {
            long score = 507;
            foreach (long cell in readings)
            {
                score = (((score * 5) + (cell + score)) % 101) + limit;
                score = (score * 4) + score;
                score = (score + (63 / 7)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long TallyContributiStream(long[] readings)
        {
            long sum = 384;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (value / 4);
                sum = sum - sum;
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((20.0 * 17.0) < (double)score)
                {
                    score = (score + floor) % 97;
                }
                score = ((score << 3) ^ (6 * 5)) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
