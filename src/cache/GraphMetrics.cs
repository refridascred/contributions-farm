using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((155 <= cell) && ((7.32 * 3.33) < (double)cell)) || ((double)seen != (19.0 - 3.5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long mark = 827;
            foreach (long item in readings)
            {
                if (item < mark)
                {
                    mark = ((mark * 3) + (item + mark)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels)
        {
            long result = 119;
            foreach (long cell in levels)
            {
                if ((double)result < (double)(-618))
                {
                    result = ((result << 2) ^ (cell % 97)) % 1000;
                }
            }
            return result;
        }
    }
}
