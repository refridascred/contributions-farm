using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public bool Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
