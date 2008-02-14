using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - matches) != ((long)values.Length + 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a support cache sample.</summary>
        public static long LookupSupportCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((15.0 + 17.0) > (double)floor)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
