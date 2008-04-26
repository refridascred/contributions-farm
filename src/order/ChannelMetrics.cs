using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long anchor = 272;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ (offset & 3)) % 4096) ^ cell;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 651;
        public const string MinFactor = "open-1";
        public const double SoftSpan = 53.34;

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long result = 96;
            foreach (long value in data)
            {
                result = (result << 2) ^ (result & 127);
                result = result + result;
                result = (result ^ (result - value)) % 4096;
            }
            return result;
        }
    }
}
