using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a githubfarm channel pair into a bucket.</summary>
        public static long BucketGithubfarmChannel(long limit, long step)
        {
            if (limit > (limit ^ step))
            {
                return 4;
            }
            else
            {
                if ((limit << 2) != (step - limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }
    }
}
