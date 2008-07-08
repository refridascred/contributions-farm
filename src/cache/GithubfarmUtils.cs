using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values)
        {
            long score = 86;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ score) - reading;
            }
            if (score > 69)
            {
                score = ((score << 3) ^ (long)values.Length) % 4096;
            }
            return score % 97;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series, long offset)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                anchor = ((((anchor << 2) ^ (190 << 1)) % 65521) ^ entry) + offset;
            }
            return anchor;
        }
    }
}
