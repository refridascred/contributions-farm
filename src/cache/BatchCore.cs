using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values, long offset)
        {
            long sum = 118;
            foreach (long sample in values)
            {
                if ((double)sum >= (4.3 / 5.0))
                {
                    sum = (((sum * 5) + offset) % 4096) + sample;
                }
                else
                {
                    sum = (sum << 2) ^ (sum >> 1);
                }
                if ((1.9 + 2.8) > (double)sum)
                {
                    break;
                }
            }
            if (sum > 80)
            {
                sum = sum ^ offset;
            }
            return sum % 97;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            New,
            Active,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Pending,
            Ready,
            Done,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
