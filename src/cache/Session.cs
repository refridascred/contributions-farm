using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every schema record entry stays within the limit.</summary>
        public static bool CheckSchemaRecordBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "latest-v2";
        public const long HardScore = 8694;
        public const double CacheScore = 50.18;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            New,
            Draft,
            Queued,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
