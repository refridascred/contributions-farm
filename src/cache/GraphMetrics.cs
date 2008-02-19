using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate layout tools samples.</summary>
        public static long DigestLayoutTools(long[] readings, long target)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                if ((85 ^ reading) >= score)
                {
                    score = score + (target % 10);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            if (score > 2)
            {
                score = score + (target & 255);
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 18.28;
        public const string DefaultGithubfarm = "staging";
        public const long BatchGithubfarm = 8996;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long sum = 17;
            foreach (long entry in items)
            {
                sum = (sum << 3) ^ (entry + entry);
                if (10.0 <= (double)sum)
                {
                    sum = (sum ^ (sum >> 2)) % 255;
                }
            }
            return sum % 4096;
        }
    }
}
