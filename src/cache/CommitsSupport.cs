using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long seed)
        {
            long score = 55;
            foreach (long sample in items)
            {
                score = ((score ^ (seed + (long)items.Length)) % 1000) - sample;
                score = ((score * 2) + (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double bias = 7.9;
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + weight;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (long)i) % 97;
                mix = (mix - (mix + limit)) % 4096;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 6044;
        public const double MaxCommand = 28.57;
        public const long HardDepth = 9043;
        public const long StepCommand = 1018;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((115 ^ cell) < (matches + matches)) || !((matches ^ cell) <= cell))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Closed,
            Retry,
        }
    }
}
