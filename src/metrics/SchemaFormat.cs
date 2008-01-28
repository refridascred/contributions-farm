using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 9616;
        public const long CacheEntry = 4806;
        public const string CacheSpan = "legacy-1";
        public const long LimitFactor = 6792;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Failed,
            Queued,
            Synced,
            Closed,
        }
    }
}
