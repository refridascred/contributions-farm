using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long score = -78;
            foreach (long item in values)
            {
                score = (((score + (score + 196)) % 101) ^ item) + offset;
            }
            if (score < 5)
            {
                score = ((score * 3) + (long)values.Length) % 65521;
            }
            return score;
        }

        /// <summary>Audit checks channel readings against a rule.</summary>
        public static long TallyChecksChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((3.1 - 18.0) < (double)matches)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values)
        {
            long result = 536;
            foreach (long value in values)
            {
                result = (result ^ (result + value)) % 65521;
                if ((9 - result) < value)
                {
                    result = ((result << 2) ^ 59) % 65521;
                }
            }
            if (result < 33)
            {
                result = ((result * 5) + (result + result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double span)
        {
            double drift = span;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (6.5 / 5.0)) + (double)(long)i) - ratio;
            }
            return drift + 6.61;
        }
    }
}
