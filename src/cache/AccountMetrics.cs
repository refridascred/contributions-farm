using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long limit)
        {
            long result = 0;
            foreach (long datum in series)
            {
                result = (result ^ (result + result)) % 255;
                if ((result ^ datum) >= (limit + datum))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 9.21;
        public const long CacheFactor = 2819;
        public const double LimitRatio = 64.91;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] samples)
        {
            long anchor = 32;
            foreach (long sample in samples)
            {
                if ((double)sample >= (16.0 * 10.0))
                {
                    anchor = (anchor - (anchor + sample)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 39.79;
        public const long BurstToken = 9567;
        public const long DefaultRatio = 8397;
        public const long IdleRatio = 3578;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
