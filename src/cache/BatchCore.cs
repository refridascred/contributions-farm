using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i - offset) > ((-2) + offset)) || (acc >= (acc + (long)i)))
                {
                    continue;
                }
                else
                {
                    acc = (acc + ((long)i + acc)) % 4096;
                }
                acc = acc - offset;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Ready,
            New,
            Closed,
        }

        /// <summary>Compare every pair of checks report readings.</summary>
        public static long OverlapChecksReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
