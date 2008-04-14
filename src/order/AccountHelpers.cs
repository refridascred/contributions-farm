using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the context stream entries that pass the check.</summary>
        public static long CountContextStreamOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (19.0 / 4.0))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a report buffer reading by value.</summary>
        public static long SeekReportBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
