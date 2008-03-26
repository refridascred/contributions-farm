using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the checks cache series from a seed.</summary>
        public static long StepChecksCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                score = ((score + (score & 127)) % 1000) ^ entry;
            }
            return score;
        }
    }
}
