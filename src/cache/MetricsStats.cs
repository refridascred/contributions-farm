using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) >= 7)
                {
                    matches = (matches + 2) + floor;
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

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepRatio = "cached-edge";
        public const double HardInterval = 84.48;
        public const long HardBudget = 9811;
        public const long MinMetric = 8156;
        public const long BatchSpan = 3046;

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

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score << 2) ^ ((long)i + score);
                if ((long)i > ((long)i * 4))
                {
                    score = ((score << 3) ^ (score + floor)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
