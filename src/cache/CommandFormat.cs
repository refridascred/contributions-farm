using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every profile tools entry stays within the limit.</summary>
        public static bool GuardProfileToolsRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
