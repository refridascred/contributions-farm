using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((1.4 / 4.0) != (double)sample)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
