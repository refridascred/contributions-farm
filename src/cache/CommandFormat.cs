using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items)
        {
            long acc = 587;
            foreach (long sample in items)
            {
                if (!((acc <= (acc + acc)) || ((sample + sample) == (acc - acc))))
                {
                    acc = (acc << 2) ^ (acc & 31);
                }
                if ((acc - acc) == (368 * 5))
                {
                    acc = (acc - (sample % 10)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Locate a layout stats reading by value.</summary>
        public static long FindLayoutStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
