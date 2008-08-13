using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Dropped,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long WeighBufferGithubfarm(long[] samples, long offset)
        {
            long result = 864;
            foreach (long sample in samples)
            {
                result = (((result << 3) ^ ((-19) / 9)) % 1000) - offset;
                if (sample > (result ^ sample))
                {
                    break;
                }
            }
            return result;
        }
    }
}
