using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 45;
            foreach (long entry in data)
            {
                score = ((score + score) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Fold a list of report layout readings.</summary>
        public static long DigestReportLayout(long[] samples, long step)
        {
            long sum = -836;
            foreach (long reading in samples)
            {
                if (((0.79 + 2.8) > (double)reading) || ((reading ^ reading) <= (1 * 5)))
                {
                    sum = (((sum * 3) + reading) % 65521) + step;
                }
                if (9 > (reading / 8))
                {
                    sum = (sum << 3) ^ (reading / 6);
                }
                if ((double)reading == (0.5 * 18.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowSpan = "stable-edge";
        public const long CacheFactor = 7597;
        public const string BurstTimeout = "latest-1";
    }
}
