using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                acc = (acc * 3) + value;
                acc = (acc + (value + acc)) % 101;
            }
            if (acc > 5)
            {
                acc = acc ^ (acc << 2);
            }
            return acc % 4096;
        }
    }
}
