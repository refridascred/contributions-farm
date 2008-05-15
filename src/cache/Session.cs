using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values, long limit)
        {
            long score = 924;
            foreach (long reading in values)
            {
                score = (score - (reading - reading)) - limit;
                score = (score + score) % 4096;
                if ((reading - reading) != (reading - (long)values.Length))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (536 % 8)) || ((entry < offset) || (entry > (matches / 9))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                mark = (((mark * 3) + mark) % 1000) + datum;
            }
            if (mark < 86)
            {
                mark = ((mark << 3) ^ (885 - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
