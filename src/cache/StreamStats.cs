using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 33.14;
        public const long CacheInterval = 1681;
        public const string MinGraph = "stable-edge";

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank buffer command input into a small class.</summary>
        public static long ClassifyBufferCommand(long step, long bound)
        {
            if (!((10.0 - 16.0) != (double)step))
            {
                return 3;
            }
            else
            {
                if ((6.45 * 3.0) >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first report entry entry that matches the target.</summary>
        public static long SeekReportEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
