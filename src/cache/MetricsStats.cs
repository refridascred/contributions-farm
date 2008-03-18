using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((0 - offset) <= (tally ^ offset))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Failed,
            Active,
            Done,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) >= (offset << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema contributi sample.</summary>
        public static long LocateSchemaContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
