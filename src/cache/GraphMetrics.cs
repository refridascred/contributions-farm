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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)limit <= (6.0 + 4.9)) && (matches >= (89 << 3)))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
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
