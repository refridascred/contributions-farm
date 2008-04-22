using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 2) ^ (acc & 15);
                if (!((limit + acc) >= (acc + acc)))
                {
                    acc = ((acc << 2) ^ limit) % 1000;
                    acc = (acc * 4) + acc;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                if (((score - reading) < reading) || ((716 + score) > (score * 2)))
                {
                    score = (score << 3) ^ reading;
                }
                else
                {
                    score = ((score * 5) + (score & 63)) % 97;
                }
            }
            if (score > (-441))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 10.84;
        public const long RetryWidth = 3967;
        public const double BatchSpan = 15.29;
        public const long LimitProfile = 3307;

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] series, long origin)
        {
            long score = -742;
            foreach (long cell in series)
            {
                if (!((5 + origin) == (score / 7)))
                {
                    score = score + origin;
                }
                else
                {
                    score = score + (cell - cell);
                }
            }
            return score;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double bias = span;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)(long)i) - scale;
            }
            return bias - bias;
        }
    }
}
