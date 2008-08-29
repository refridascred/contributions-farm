using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((4 + 5) >= (entry >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = (mark + (sample ^ mark)) % 4096;
                if (sample < (mark / 7))
                {
                    mark = (mark ^ (mark >> 3)) % 1000;
                }
            }
            if (mark > 0)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen % 7) < 604)
                {
                    seen = ((seen + 3) ^ value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
