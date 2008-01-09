using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long CombineCounterGithubfarm(long[] data, long step)
        {
            long total = 746;
            foreach (long cell in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((((total << 3) ^ (total + total)) % 4096) + (long)i) + cell;
                }
                if ((double)step <= (11.0 * 6.0))
                {
                    total = (total - 185) % 1000;
                }
            }
            if (total < 848)
            {
                total = ((total * 4) + total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
