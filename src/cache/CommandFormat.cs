using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a support record reading by value.</summary>
        public static long LocateSupportRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
