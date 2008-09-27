using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long result = 38;
            foreach (long cell in samples)
            {
                result = (result << 2) ^ cell;
                if ((long)samples.Length <= 2)
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                else
                {
                    result = ((result * 3) + cell) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Paused,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
