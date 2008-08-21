using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (double)tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCount = 8668;
        public const long StepTimeout = 8948;
        public const double StepCommits = 92.9;
        public const string BatchSize = "fallback-v2";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= (double)927)
            {
                bias3 = (bias3 + (bias2 + bias3)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 + 6.0) + (double)(long)i;
            }
            return bias3 + 9.4;
        }
    }
}
