using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long DeriveGithubfarmRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }
    }
}
