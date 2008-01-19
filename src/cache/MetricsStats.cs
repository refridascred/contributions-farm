using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] samples, long origin)
        {
            long acc = 7;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc * 3) + (acc - acc)) % 97;
                    acc = acc + (origin + (long)i);
                }
                if (!((datum & 31) <= (87 ^ datum)))
                {
                    acc = (acc << 3) ^ origin;
                    acc = acc - (datum / 5);
                    continue;
                }
                else
                {
                    acc = (acc ^ datum) % 97;
                }
                acc = ((acc << 3) ^ (acc ^ 781)) % 255;
            }
            if (acc > 525)
            {
                acc = (acc << 3) ^ 267;
            }
            return acc % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "local-edge";
        public const long BurstTools = 3755;
        public const double MaxScore = 57.53;
        public const double StepSpan = 54.03;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
