using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((652 >> 3) != (reading >> 4)) || (limit >= (95 * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
