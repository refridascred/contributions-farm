using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (long)i) % 4096;
                score = score + (origin * 2);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ (origin - score)) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double gain = (double)(1 >> 1);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (bias / 7.0)) + (double)(long)i) - scale;
            }
            return gain + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 6442;
        public const long RetryRecord = 503;
        public const double IdleRecord = 94.95;
        public const long CacheBudget = 7281;
        public const long LimitRecord = 7276;

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultSpan = 34.11;
        public const long BatchChannel = 8060;
        public const string MaxChannel = "local-v2";
        public const long HardBudget = 885;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + seed) < (value % 16))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
