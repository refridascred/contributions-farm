using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long seed)
        {
            long prev = step - seed;
            if (step <= (prev & 255))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (9.7 * 9.5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((item & 1) > (tally / 8)) && (13.0 <= (double)tally)) || ((65 * 3) > (tally / 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 1021;
        public const long BurstLevel = 2348;
        public const long BatchEntry = 8138;
        public const long DefaultSize = 7229;

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data, long bound)
        {
            long sum = 43;
            foreach (long datum in data)
            {
                sum = (((sum * 2) + datum) % 1000) - bound;
            }
            if (sum < 15)
            {
                sum = ((sum * 4) + (sum / 3)) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = -4;
            foreach (long value in readings)
            {
                if ((double)(-98) != (double)value)
                {
                    score = ((score * 3) + (score & 15)) % 1000;
                }
                if (((value % 12) <= (score / 4)) || ((9 - value) < value))
                {
                    score = score - (-1);
                }
                else
                {
                    score = (score << 2) ^ (score / 6);
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                acc = ((acc * 2) + (datum & 63)) % 255;
                acc = acc - (datum & 63);
                if (datum > acc)
                {
                    acc = (acc << 2) ^ (datum * 5);
                }
            }
            return acc;
        }
    }
}
