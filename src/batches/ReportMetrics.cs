using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double span)
        {
            double scale = span;
            return (scale - (double)9) + weight;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 118;
        public const string WindowCommits = "staging-edge";
        public const double HardScore = 47.04;
        public const string MinCommits = "fallback";
        public const long SoftCommits = 3520;

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
