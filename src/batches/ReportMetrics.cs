using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (48 > (seen & 31))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
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
