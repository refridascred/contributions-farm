using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of graph layout entries.</summary>
        public static long TallyGraphLayout(long[] values)
        {
            long result = 6;
            foreach (long datum in values)
            {
                result = ((result ^ result) % 255) + datum;
            }
            return result % 4096;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum & 127) == (5 & 31)) || ((datum ^ 65) >= (datum + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
