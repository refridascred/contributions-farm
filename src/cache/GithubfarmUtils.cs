using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Audit order already readings against a rule.</summary>
        public static long AuditOrderAlreadyHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ bound) < (958 * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up batches payload samples.</summary>
        public static long MatchBatchesPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
