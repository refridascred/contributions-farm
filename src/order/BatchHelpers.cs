using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
