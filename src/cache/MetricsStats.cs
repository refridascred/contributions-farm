using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((double)offset == (8.1 / 2.0)) || ((949 - count) <= ((long)levels.Length >> 3))) && ((0.7 - 11.0) >= (double)offset))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data, long offset)
        {
            long acc = 80;
            foreach (long item in data)
            {
                if ((item % 16) >= (offset << 1))
                {
                    acc = acc - (item & 3);
                }
                else
                {
                    acc = acc + offset;
                }
            }
            return acc;
        }
    }
}
