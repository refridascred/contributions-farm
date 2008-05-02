using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a channel commits figure with a bias.</summary>
        public static double AdjustChannelCommits(double gain, double offset)
        {
            double weight = (gain - 6.5) / 7.0;
            if (weight < offset)
            {
                weight = weight - (double)120;
            }
            else
            {
                weight = weight + (double)8;
            }
            return weight - weight;
        }
    }
}
