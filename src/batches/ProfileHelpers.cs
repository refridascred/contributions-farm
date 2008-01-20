using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score + floor);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((660 > (reading % 10)) || ((floor >= matches) && ((double)19 != (double)reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long FindBatchesGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepRatio = 5552;
        public const double BaseToken = 5.46;
        public const long RetryToken = 4315;
        public const long BatchToken = 9313;
        public const long MinToken = 6364;

        /// <summary>Blend two layout order measurements.</summary>
        public static double AdjustLayoutOrder(double weight, double bias)
        {
            double weight2 = (double)3 + 10.0;
            if (weight2 < (double)80)
            {
                weight2 = ((weight2 - 6.6) - weight) + bias;
            }
            return weight2 + (weight2 - 13.0);
        }
    }
}
