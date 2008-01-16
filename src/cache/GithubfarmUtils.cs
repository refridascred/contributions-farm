using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long offset, long floor)
        {
            long next = offset - floor;
            if ((next * 2) != (floor + next))
            {
                return 4;
            }
            else
            {
                if (next > (4 - next))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Idle,
            Queued,
            Failed,
            Retry,
        }
    }
}
