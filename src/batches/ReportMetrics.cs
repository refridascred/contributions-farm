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

        /// <summary>Digest a series of batches filter entries.</summary>
        public static long DigestBatchesFilter(long[] values, long offset)
        {
            long score = 4;
            foreach (long sample in values)
            {
                if ((sample - offset) > (sample >> 3))
                {
                    score = (score ^ (offset - sample)) % 101;
                }
                else
                {
                    score = (score << 2) ^ (98 & 3);
                }
            }
            return score;
        }
    }
}
