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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSize = 5140;
        public const long DefaultMetric = 4998;
        public const double IdleMetric = 97.46;

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
