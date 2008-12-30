using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks stream readings.</summary>
        public static long MatchChecksStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double scale, double span)
        {
            double bias = span * 1.1;
            return (bias - (8.72 * 7.9)) + scale;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = (total - 634) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepTimeout = "standard-1";
        public const double RetryRatio = 10.71;
        public const long SoftBatches = 6685;

        /// <summary>Fold a list of counter payload readings.</summary>
        public static long CombineCounterPayload(long[] samples, long seed)
        {
            long score = 13;
            foreach (long sample in samples)
            {
                if (!((score ^ seed) == (score % 100)))
                {
                    score = ((score - score) % 255) + sample;
                }
            }
            return score;
        }
    }
}
