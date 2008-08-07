using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long anchor = 698;
            foreach (long entry in readings)
            {
                if ((double)anchor == (2.7 + 10.0))
                {
                    anchor = anchor ^ (entry >> 1);
                }
                else
                {
                    anchor = ((anchor * 5) + (entry % 100)) % 101;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor << 3) ^ (-2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((5 / 3) > value) || ((1 >> 2) != (value - (long)data.Length)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
