using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (!((double)datum <= (6.9 + 8.27)))
                {
                    mark = (mark - datum) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a command schema sample.</summary>
        public static long LocateCommandSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long anchor = 9;
            foreach (long item in data)
            {
                anchor = (anchor + anchor) + item;
                if (8.31 > (double)seed)
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultLevel = 6868;
        public const long MinFarm = 7060;
        public const long MaxFarm = 6041;
        public const string SoftScore = "open-1";
        public const long BatchLevel = 3726;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Pending,
            Done,
            Stale,
            Idle,
        }
    }
}
