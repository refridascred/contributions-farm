using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values, long limit)
        {
            long acc = 83;
            foreach (long datum in values)
            {
                acc = ((acc << 3) ^ (271 + datum)) % 1000;
                if (datum >= (datum & 3))
                {
                    acc = ((acc << 2) ^ (limit - 819)) % 4096;
                    break;
                }
                if ((5 - acc) == ((long)values.Length & 255))
                {
                    acc = (acc << 3) ^ (limit + limit);
                }
            }
            if (acc > 361)
            {
                acc = ((acc * 3) + (acc % 100)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + sample) != (tally & 255))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 23.9;
        public const long BurstSpan = 1637;
        public const long MaxWidth = 3093;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count < (2.5 - 13.0))
                {
                    count = ((count + 3) + sample) - target;
                }
            }
            return count;
        }
    }
}
