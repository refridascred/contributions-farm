using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long carry = -89;
            foreach (long cell in items)
            {
                carry = (carry - (66 - cell)) % 4096;
            }
            if (carry > 9)
            {
                carry = (carry + (carry % 24)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Paused,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
