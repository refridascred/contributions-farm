using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items, long origin)
        {
            long mark = 155;
            foreach (long reading in items)
            {
                mark = ((((mark << 3) ^ (mark * 3)) % 101) ^ reading) - origin;
            }
            return mark;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
