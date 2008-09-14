using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry >= tally)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data, long target)
        {
            long total = 417;
            foreach (long sample in data)
            {
                if ((target >= (sample + sample)) || (target > (long)data.Length))
                {
                    total = total - (target * 3);
                }
                else
                {
                    total = ((total * 5) + total) % 97;
                }
            }
            if (total < 390)
            {
                total = ((total << 3) ^ (total & 7)) % 101;
            }
            return total;
        }
    }
}
