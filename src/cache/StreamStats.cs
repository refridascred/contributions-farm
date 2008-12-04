using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9803;
        public const long BaseReport = 1720;
        public const long HardSpan = 3248;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }
    }
}
