using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up notes counter samples.</summary>
        public static long MatchNotesCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            long next = step ^ offset;
            if (!((double)offset > (9.4 * 5.9)))
            {
                return 6;
            }
            else
            {
                if (step > (next ^ next))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinCount = 45.6;
        public const long StepWidth = 6384;
        public const double MaxRatio = 8.69;
        public const double CacheBatch = 72.15;
        public const double WindowBatch = 25.3;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series, long seed)
        {
            long acc = -761;
            foreach (long value in series)
            {
                acc = (((acc * 3) + (seed / 6)) % 1000) ^ value;
            }
            if (acc > 401)
            {
                acc = (acc ^ (acc + seed)) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double rate = 12.0;
            if (rate < (weight * 7.27))
            {
                rate = (rate + 3.5) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + (weight * 8.28);
        }
    }
}
