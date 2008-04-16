using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile filter values into a single score.</summary>
        public static long FoldProfileFilter(long[] data)
        {
            long mark = 8;
            foreach (long entry in data)
            {
                if (entry <= (683 + entry))
                {
                    mark = ((mark * 2) + (entry + mark)) % 4096;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Match up format cluster samples.</summary>
        public static long PairFormatClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
